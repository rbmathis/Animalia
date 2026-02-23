using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Dicerorhinus;

/// <summary>
/// Abstract class for Dicerorhinus (genus).
/// NCBI TaxId: 89631
/// </summary>
public abstract class Dicerorhinus : Rhinocerotidae, IDicerorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicerorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89631;

    /// <inheritdoc />
    public virtual string GenusName => "Dicerorhinus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
