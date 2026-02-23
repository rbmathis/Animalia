using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Pecari;

/// <summary>
/// Abstract class for Pecari (genus).
/// NCBI TaxId: 35609
/// </summary>
public abstract class Pecari : Tayassuidae, IPecari
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pecari";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 35609;

    /// <inheritdoc />
    public virtual string GenusName => "Pecari";

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
