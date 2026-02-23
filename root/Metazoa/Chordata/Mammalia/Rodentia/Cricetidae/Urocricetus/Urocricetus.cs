using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Urocricetus;

/// <summary>
/// Abstract class for Urocricetus (genus).
/// NCBI TaxId: 2175848
/// </summary>
public abstract class Urocricetus : Cricetidae, IUrocricetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urocricetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2175848;

    /// <inheritdoc />
    public virtual string GenusName => "Urocricetus";

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
