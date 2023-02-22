
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;

namespace Alb.OpenPlayConnect.RemoteConfigs.ADO.Controllers
{
    [ApiController]
    [Route("api/v1/OTT/STB")]
    public class STBController : ControllerBase
    {

        private readonly ILogger<STBController> _logger;

        public STBController(ILogger<STBController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userAgent"></param>
        /// <param name="json_file"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Route("{userAgent}/config/{json_file}")]
        public async Task<IActionResult> GetConfigs(string? userAgent, string? json_file, CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogInformation("Start IChannelManagerProvider MostViewLiveChannels");
                if (string.IsNullOrEmpty(json_file))
                {
                    return StatusCode((int)HttpStatusCode.BadGateway, "Without config file defined.");
                }
                var a = Util.ReadConfigFileAsync(userAgent, json_file);
                if (a == null || (a != null && a.Result == null))
                    return StatusCode((int)HttpStatusCode.NoContent, "Without content finded.");

                return Ok(a.Result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error to get config file: {0}. Exception: {1}", json_file, ex.Message);
                throw;
            }
            finally
            {
                _logger.LogInformation("End Get config file");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userAgent"></param>
        /// <param name="folder"></param>
        /// <param name="json_file"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Route("{userAgent}/{folder}/config/{json_file}")]
        public IActionResult GetConfigs(string? userAgent, string? folder, string? json_file, CancellationToken cancellationToken = default)
        {
            try
            {
                if (string.IsNullOrEmpty(json_file))
                {
                    return StatusCode((int)HttpStatusCode.BadGateway, "Without config file defined.");
                }

                if (string.IsNullOrEmpty(folder))
                {
                    return StatusCode((int)HttpStatusCode.BadGateway, "Without config version folder defined.");
                }

                var a = Util.ReadConfigVersionFileAsync(userAgent, folder, json_file);
                if (a == null || (a != null && a.Result == null))
                    return StatusCode((int)HttpStatusCode.NoContent, "Without content finded.");
                return Ok(a.Result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error to get configuration file {0} to version: {1}. Exception: {2}", json_file, folder, ex.Message);
                throw;
            }
            finally
            {
                _logger.LogInformation("End Get config file");
            }
        }
    }
}