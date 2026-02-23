using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eremiascincus;

/// <summary>
/// Abstract class for Eremiascincus (genus).
/// NCBI TaxId: 220779
/// </summary>
public abstract class Eremiascincus : Scincidae, IEremiascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremiascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 220779;

    /// <inheritdoc />
    public virtual string GenusName => "Eremiascincus";

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
