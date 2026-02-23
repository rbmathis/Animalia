using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Thrichomys;

/// <summary>
/// Abstract class for Thrichomys (genus).
/// NCBI TaxId: 43326
/// </summary>
public abstract class Thrichomys : Echimyidae, IThrichomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thrichomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43326;

    /// <inheritdoc />
    public virtual string GenusName => "Thrichomys";

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
