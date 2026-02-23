using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Wilfredomys;

/// <summary>
/// Abstract class for Wilfredomys (genus).
/// NCBI TaxId: 89127
/// </summary>
public abstract class Wilfredomys : Cricetidae, IWilfredomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wilfredomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89127;

    /// <inheritdoc />
    public virtual string GenusName => "Wilfredomys";

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
