﻿using Data.Mongo.Collections;
using Identity.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Account;
using Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ILoginLogService _loginLogService;
        public AccountController(IAccountService accountService, ILoginLogService loginLogService)
        {
            _accountService = accountService;
            _loginLogService = loginLogService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            //auth
            var result = await _accountService.AuthenticateAsync(request);
            if (result.Errors == null || !result.Errors.Any())
            {
                //mongo usage example
                LoginLog log = new LoginLog()
                {
                    LoginTime = DateTime.Now,
                    UserEmail = request.Email
                };
                // await _loginLogService.Add(log);
            }
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterRequest request)
        {
            var uri = $"{Request.Scheme}://{Request.Host.Value}";
            return Ok(await _accountService.RegisterAsync(request, uri));
        }
        [HttpPost("register-with-cccd")]
        public async Task<IActionResult> RegisterAsync(AuthenticationRequestEmail request)
        {
            //var uri = $"{Request.Scheme}://{Request.Host.Value}";
            try
            {
                await _accountService.AuthenticateWithEmailAsync(request);
                return Ok(new
                {
                    message = $"Register sucess, check your email {request.Email}",
                    code = 201
                });
            }
            catch (System.Exception ex)
            {
                return BadRequest(new
                {
                    message = $"Register fail, {ex.Message.ToString()}",
                    code = 400
                });
            }

        }
        [HttpPost("login-with-cccd")]
        public async Task<IActionResult> LoginAsync(AuthenticationRequestEmail request)
        {
            //var uri = $"{Request.Scheme}://{Request.Host.Value}";
            try
            {
                await _accountService.AuthenticateWithEmailGetCodeAsync(request);
                return Ok(new
                {
                    message = $"Check your email {request.Email}",
                    code = 200
                });
            }
            catch (System.Exception ex)
            {
                return BadRequest(new
                {
                    message = $"Get code fail, {ex.Message.ToString()}",
                    code = 400
                });
            }

        }

         [HttpPost("validation-code")]
        public async Task<IActionResult> RegisterAsync(ValidationAuthCode request)
        {
            //var uri = $"{Request.Scheme}://{Request.Host.Value}";
            try
            {
              var response =  await _accountService.ValidationAuthCode(request);
                return Ok(new
                {
                    message = $"Validate code success",
                    data = response,
                    code = 200
                });
            }
            catch (System.Exception ex)
            {
                return BadRequest(new
                {
                    message = $"Validate code fail, {ex.Message.ToString()}",
                    code = 400
                });
            }

        }

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmailAsync([FromQuery] string userId, [FromQuery] string code)
        {
            return Ok(await _accountService.ConfirmEmailAsync(userId, code));
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPasswordAsync(ForgotPasswordRequest request)
        {
            var uri = $"{Request.Scheme}://{Request.Host.Value}";
            await _accountService.ForgotPasswordAsync(request, uri);
            return Ok();
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordRequest request)
        {
            return Ok(await _accountService.ResetPasswordAsync(request));
        }

        [HttpPost("refreshtoken")]
        public async Task<IActionResult> RefreshTokenAsync(RefreshTokenRequest request)
        {
            return Ok(await _accountService.RefreshTokenAsync(request));
        }

        [HttpGet("logout")]
        public async Task<IActionResult> LogoutAsync(string userEmail)
        {
            return Ok(await _accountService.LogoutAsync(userEmail));
        }

        private string GenerateIPAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
    }
}