namespace AnimalKingdom.root.Metazoa;

/// <summary>
/// Defines the contract for Kingdom-level classification in biological taxonomy.
/// Kingdom is the second-highest taxonomic rank after Domain.
/// </summary>
public interface IMetazoa
{
    /// <summary>
    /// Gets the scientific name of the kingdom.
    /// </summary>
    string KingdomName { get; }

    /// <summary>
    /// Gets the defining characteristics of this kingdom.
    /// </summary>
    string[] KingdomCharacteristics { get; }

    /// <summary>
    /// Indicates whether organisms in this kingdom are multicellular.
    /// </summary>
    bool IsMulticellular { get; }

    /// <summary>
    /// Gets the primary mode of nutrition for this kingdom.
    /// </summary>
    string NutritionMode { get; }
}
