using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Simiscincus;

/// <summary>
/// Abstract class for Simiscincus (genus).
/// NCBI TaxId: 394173
/// </summary>
public abstract class Simiscincus : Scincidae, ISimiscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Simiscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 394173;

    /// <inheritdoc />
    public virtual string GenusName => "Simiscincus";

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
