using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Macruromys;

/// <summary>
/// Abstract class for Macruromys (genus).
/// NCBI TaxId: 442577
/// </summary>
public abstract class Macruromys : Muridae, IMacruromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macruromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442577;

    /// <inheritdoc />
    public virtual string GenusName => "Macruromys";

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
