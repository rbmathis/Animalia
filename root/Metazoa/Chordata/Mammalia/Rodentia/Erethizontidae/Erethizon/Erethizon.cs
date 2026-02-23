using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Erethizon;

/// <summary>
/// Abstract class for Erethizon (genus).
/// NCBI TaxId: 34843
/// </summary>
public abstract class Erethizon : Erethizontidae, IErethizon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erethizon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34843;

    /// <inheritdoc />
    public virtual string GenusName => "Erethizon";

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
