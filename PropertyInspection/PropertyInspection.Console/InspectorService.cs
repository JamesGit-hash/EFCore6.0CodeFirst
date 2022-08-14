// See https://aka.ms/new-console-template for more information
using PropertyInspection.Data;

public class InspectorService : IInspectorService
{
    private readonly PropertyInspectionContext _context;

    public InspectorService(PropertyInspectionContext context)
    {
        _context = context;
    }

    public void AddInspector()
    {
        _context.Inspectors.Add(new Inspector
        {
            Name = "James"
        });

        _context.SaveChanges();
    }
}