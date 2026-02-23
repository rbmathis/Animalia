using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Cricetus;

/// <summary>
/// Abstract class for Cricetus (genus).
/// NCBI TaxId: 10033
/// </summary>
public abstract class Cricetus : Cricetidae, ICricetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cricetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10033;

    /// <inheritdoc />
    public virtual string GenusName => "Cricetus";

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
