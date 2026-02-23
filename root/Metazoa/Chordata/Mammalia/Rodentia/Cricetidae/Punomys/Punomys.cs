using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Punomys;

/// <summary>
/// Abstract class for Punomys (genus).
/// NCBI TaxId: 1258728
/// </summary>
public abstract class Punomys : Cricetidae, IPunomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Punomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1258728;

    /// <inheritdoc />
    public virtual string GenusName => "Punomys";

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
