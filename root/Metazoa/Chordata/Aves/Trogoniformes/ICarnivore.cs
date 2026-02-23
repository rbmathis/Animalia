namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes;

/// <summary>
/// Defines traits specific to carnivorous mammals.
/// </summary>
public interface ICarnivore
{
    /// <summary>
    /// Indicates whether the organism has carnassial teeth.
    /// </summary>
    bool HasCarnassialTeeth { get; }

    /// <summary>
    /// Gets the primary diet type.
    /// </summary>
    string DietType { get; }

    /// <summary>
    /// Gets the digestive system adaptations for meat consumption.
    /// </summary>
    string[] DigestiveAdaptations { get; }
}
