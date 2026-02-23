using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pogonomelomys;

/// <summary>
/// Abstract class for Pogonomelomys (genus).
/// NCBI TaxId: 442597
/// </summary>
public abstract class Pogonomelomys : Muridae, IPogonomelomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pogonomelomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442597;

    /// <inheritdoc />
    public virtual string GenusName => "Pogonomelomys";

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
