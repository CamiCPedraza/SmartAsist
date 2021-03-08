using InsuranceWeb.Models;
using InsuranceWeb.Repository.Definitions;
using InsuranceWeb.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace InsuranceWeb.Services.Implementations
{
    public class AgentService : IAgentService
    {
        private readonly IRepository<Agent> _agentRepository;

        public AgentService(IRepository<Agent> agentRepository)
        {
            _agentRepository = agentRepository;
        }

        public IEnumerable<Agent> GetAgents()
        {

            return _agentRepository.GetAll(new Agent());
        }

        public bool SaveAgent(Agent agent)
        {
            agent.CreatedDate = DateTime.UtcNow;
            agent.Id = Guid.NewGuid();
            return _agentRepository.Add(agent);
        }
    }
}
