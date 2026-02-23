using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Ceratotherium;

/// <summary>
/// Abstract class for Ceratotherium (genus).
/// NCBI TaxId: 9806
/// </summary>
public abstract class Ceratotherium : Rhinocerotidae, ICeratotherium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceratotherium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9806;

    /// <inheritdoc />
    public virtual string GenusName => "Ceratotherium";

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
