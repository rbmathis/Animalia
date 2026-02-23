using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apomys;

/// <summary>
/// Abstract class for Apomys (genus).
/// NCBI TaxId: 238001
/// </summary>
public abstract class Apomys : Muridae, IApomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238001;

    /// <inheritdoc />
    public virtual string GenusName => "Apomys";

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
