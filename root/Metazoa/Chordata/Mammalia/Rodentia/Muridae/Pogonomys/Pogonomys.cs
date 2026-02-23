using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pogonomys;

/// <summary>
/// Abstract class for Pogonomys (genus).
/// NCBI TaxId: 442599
/// </summary>
public abstract class Pogonomys : Muridae, IPogonomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pogonomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442599;

    /// <inheritdoc />
    public virtual string GenusName => "Pogonomys";

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
