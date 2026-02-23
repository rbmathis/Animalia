using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Heterogeomys;

/// <summary>
/// Abstract class for Heterogeomys (genus).
/// NCBI TaxId: 2964404
/// </summary>
public abstract class Heterogeomys : Geomyidae, IHeterogeomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterogeomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2964404;

    /// <inheritdoc />
    public virtual string GenusName => "Heterogeomys";

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
