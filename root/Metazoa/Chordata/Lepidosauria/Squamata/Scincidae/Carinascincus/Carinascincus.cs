using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Carinascincus;

/// <summary>
/// Abstract class for Carinascincus (genus).
/// NCBI TaxId: 2219902
/// </summary>
public abstract class Carinascincus : Scincidae, ICarinascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carinascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2219902;

    /// <inheritdoc />
    public virtual string GenusName => "Carinascincus";

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
