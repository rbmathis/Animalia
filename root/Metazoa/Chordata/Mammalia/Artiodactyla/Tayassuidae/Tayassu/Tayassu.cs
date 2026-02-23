using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Tayassu;

/// <summary>
/// Abstract class for Tayassu (genus).
/// NCBI TaxId: 9828
/// </summary>
public abstract class Tayassu : Tayassuidae, ITayassu
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tayassu";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9828;

    /// <inheritdoc />
    public virtual string GenusName => "Tayassu";

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
