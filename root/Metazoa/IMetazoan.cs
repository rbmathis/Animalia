namespace AnimalKingdom.root.Metazoa;

/// <summary>
/// Defines traits common to all metazoans (multicellular animals).
/// </summary>
public interface IMetazoan
{
    /// <summary>
    /// Indicates whether the organism has differentiated tissues.
    /// </summary>
    bool HasDifferentiatedTissues { get; }

    /// <summary>
    /// Gets the type of body symmetry.
    /// </summary>
    string BodySymmetry { get; }

    /// <summary>
    /// Indicates whether the organism undergoes embryonic development.
    /// </summary>
    bool HasEmbryonicDevelopment { get; }

    /// <summary>
    /// Gets the number of germ layers in embryonic development.
    /// </summary>
    int GermLayerCount { get; }
}
