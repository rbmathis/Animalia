using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Phasmasaurus;

/// <summary>
/// Abstract class for Phasmasaurus (genus).
/// NCBI TaxId: 2025342
/// </summary>
public abstract class Phasmasaurus : Scincidae, IPhasmasaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phasmasaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2025342;

    /// <inheritdoc />
    public virtual string GenusName => "Phasmasaurus";

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
