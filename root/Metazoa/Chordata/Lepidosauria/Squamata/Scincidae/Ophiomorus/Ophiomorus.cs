using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ophiomorus;

/// <summary>
/// Abstract class for Ophiomorus (genus).
/// NCBI TaxId: 273657
/// </summary>
public abstract class Ophiomorus : Scincidae, IOphiomorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophiomorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 273657;

    /// <inheritdoc />
    public virtual string GenusName => "Ophiomorus";

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
