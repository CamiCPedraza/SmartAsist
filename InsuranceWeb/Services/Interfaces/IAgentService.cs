using InsuranceWeb.Models;
using System.Collections.Generic;

namespace InsuranceWeb.Services.Interfaces
{
    public interface IAgentService
    {
        IEnumerable<Agent> GetAgents();
        bool SaveAgent(Agent agent);
    }
}
