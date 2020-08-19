using System.Collections.Generic;

namespace StarDex.Client.Models {
  public class HomeViewModel {
    public List<ConstellationButtonModel> north { get; set; }
    public List<ConstellationButtonModel> south { get; set; }
  }
}