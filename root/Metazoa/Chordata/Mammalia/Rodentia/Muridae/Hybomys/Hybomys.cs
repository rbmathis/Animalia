using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hybomys;

/// <summary>
/// Abstract class for Hybomys (genus).
/// NCBI TaxId: 71161
/// </summary>
public abstract class Hybomys : Muridae, IHybomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hybomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71161;

    /// <inheritdoc />
    public virtual string GenusName => "Hybomys";

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
