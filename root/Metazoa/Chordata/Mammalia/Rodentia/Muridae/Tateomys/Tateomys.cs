using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tateomys;

/// <summary>
/// Abstract class for Tateomys (genus).
/// NCBI TaxId: 1795473
/// </summary>
public abstract class Tateomys : Muridae, ITateomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tateomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1795473;

    /// <inheritdoc />
    public virtual string GenusName => "Tateomys";

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
