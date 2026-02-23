using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Silvascincus;

/// <summary>
/// Abstract class for Silvascincus (genus).
/// NCBI TaxId: 1540146
/// </summary>
public abstract class Silvascincus : Scincidae, ISilvascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Silvascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1540146;

    /// <inheritdoc />
    public virtual string GenusName => "Silvascincus";

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
