using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Paramelomys;

/// <summary>
/// Abstract class for Paramelomys (genus).
/// NCBI TaxId: 442593
/// </summary>
public abstract class Paramelomys : Muridae, IParamelomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paramelomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442593;

    /// <inheritdoc />
    public virtual string GenusName => "Paramelomys";

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
