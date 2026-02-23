using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Caesoris;

/// <summary>
/// Abstract class for Caesoris (genus).
/// NCBI TaxId: 2025341
/// </summary>
public abstract class Caesoris : Scincidae, ICaesoris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caesoris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2025341;

    /// <inheritdoc />
    public virtual string GenusName => "Caesoris";

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
