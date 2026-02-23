using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Stochomys;

/// <summary>
/// Abstract class for Stochomys (genus).
/// NCBI TaxId: 34855
/// </summary>
public abstract class Stochomys : Muridae, IStochomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stochomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34855;

    /// <inheritdoc />
    public virtual string GenusName => "Stochomys";

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
