namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Erpeton;

/// <summary>
/// Defines pack behavior traits.
/// </summary>
public interface IPackAnimal
{
    /// <summary>
    /// Gets the pack hierarchy structure.
    /// </summary>
    string PackHierarchy { get; }

    /// <summary>
    /// Gets the roles within the pack.
    /// </summary>
    string[] PackRoles { get; }

    /// <summary>
    /// Gets the pack communication methods.
    /// </summary>
    string[] PackCommunication { get; }

    /// <summary>
    /// Indicates whether pack members participate in cooperative care of young.
    /// </summary>
    bool HasCooperativeBreeding { get; }
}
