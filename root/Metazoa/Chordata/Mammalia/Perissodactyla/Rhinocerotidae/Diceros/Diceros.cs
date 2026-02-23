using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Diceros;

/// <summary>
/// Abstract class for Diceros (genus).
/// NCBI TaxId: 9804
/// </summary>
public abstract class Diceros : Rhinocerotidae, IDiceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9804;

    /// <inheritdoc />
    public virtual string GenusName => "Diceros";

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
