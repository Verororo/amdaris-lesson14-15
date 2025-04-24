using System.Text;

public class Beverage
{
    public List<IComponent> CoreIngridients { get; set; } = new List<IComponent>();
    public List<IComponent> AdditionalIngridients { get; set; }

    public string Name { get; set; }
    public string GetDescription()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(Name);
        if (AdditionalIngridients != null)
        {
            foreach (var component in AdditionalIngridients)
            {
                sb.Append($" + {component.GetName()}");
            }
        }

        return sb.ToString();
    }
}
