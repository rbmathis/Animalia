using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Rhinoceros;

/// <summary>
/// Abstract class for Rhinoceros (genus).
/// NCBI TaxId: 9808
/// </summary>
public abstract class Rhinoceros : Rhinocerotidae, IRhinoceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinoceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9808;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinoceros";

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
