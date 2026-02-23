using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Brachytarsomys;

/// <summary>
/// Abstract class for Brachytarsomys (genus).
/// NCBI TaxId: 107269
/// </summary>
public abstract class Brachytarsomys : Nesomyidae, IBrachytarsomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachytarsomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107269;

    /// <inheritdoc />
    public virtual string GenusName => "Brachytarsomys";

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
