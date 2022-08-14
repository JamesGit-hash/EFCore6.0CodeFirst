// See https://aka.ms/new-console-template for more information
using PropertyInspection.Data;

public class InspectorService : IInspectorService
{
    private readonly PropertyInspectionContext _context;

    public InspectorService(PropertyInspectionContext context)
    {
        _context = context;
    }

    public void Test()
    {
        //_context.Inspectors.Add(new Inspector
        //{
        //    Name = "James"
        //});

        //_context.SaveChanges();

        var agent = new Agent
        {
            Name = "Tony"
        };
        _context.Agents.Add(agent);
        _context.SaveChanges();


        var property = new PropertyTest
        {
            AgentRefId = agent.Id,
            OwnerName = "James",
            PostCode = 1,
            StreetAddress = "1 James St"
        };

        _context.Properties.Add(property);
        _context.SaveChanges();
    }
}