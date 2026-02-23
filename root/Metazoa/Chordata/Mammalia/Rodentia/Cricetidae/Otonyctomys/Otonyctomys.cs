using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Otonyctomys;

/// <summary>
/// Abstract class for Otonyctomys (genus).
/// NCBI TaxId: 1003294
/// </summary>
public abstract class Otonyctomys : Cricetidae, IOtonyctomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otonyctomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003294;

    /// <inheritdoc />
    public virtual string GenusName => "Otonyctomys";

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
