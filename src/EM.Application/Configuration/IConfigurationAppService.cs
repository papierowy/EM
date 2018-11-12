using System.Threading.Tasks;
using EM.Configuration.Dto;

namespace EM.Configuration
{
   public interface IConfigurationAppService
   {
      Task ChangeUiTheme(ChangeUiThemeInput input);
   }
}