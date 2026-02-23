using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Xeromys;

/// <summary>
/// Abstract class for Xeromys (genus).
/// NCBI TaxId: 337225
/// </summary>
public abstract class Xeromys : Muridae, IXeromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xeromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337225;

    /// <inheritdoc />
    public virtual string GenusName => "Xeromys";

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
