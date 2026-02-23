using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Abstract class for Equus (genus).
/// NCBI TaxId: 9789
/// </summary>
public abstract class Equus : Equidae, IEquus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Equus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9789;

    /// <inheritdoc />
    public virtual string GenusName => "Equus";

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
