namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia;

/// <summary>
/// Defines traits specific to mammals.
/// </summary>
public interface IMammal
{
    /// <summary>
    /// Indicates whether the organism has mammary glands.
    /// </summary>
    bool HasMammaryGlands { get; }

    /// <summary>
    /// Indicates whether the organism has hair or fur.
    /// </summary>
    bool HasHairOrFur { get; }

    /// <summary>
    /// Gets the type of dentition pattern.
    /// </summary>
    string DentitionPattern { get; }

    /// <summary>
    /// Indicates whether the organism has a four-chambered heart.
    /// </summary>
    bool HasFourChamberedHeart { get; }

    /// <summary>
    /// Gets the gestation type (placental, marsupial, or monotreme).
    /// </summary>
    string GestationType { get; }
}
