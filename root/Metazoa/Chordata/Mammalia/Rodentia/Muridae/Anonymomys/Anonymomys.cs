using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Anonymomys;

/// <summary>
/// Abstract class for Anonymomys (genus).
/// NCBI TaxId: 3148839
/// </summary>
public abstract class Anonymomys : Muridae, IAnonymomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anonymomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148839;

    /// <inheritdoc />
    public virtual string GenusName => "Anonymomys";

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
