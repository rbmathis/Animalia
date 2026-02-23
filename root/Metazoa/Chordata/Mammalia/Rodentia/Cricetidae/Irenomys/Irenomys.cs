using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Irenomys;

/// <summary>
/// Abstract class for Irenomys (genus).
/// NCBI TaxId: 29112
/// </summary>
public abstract class Irenomys : Cricetidae, IIrenomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Irenomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29112;

    /// <inheritdoc />
    public virtual string GenusName => "Irenomys";

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
