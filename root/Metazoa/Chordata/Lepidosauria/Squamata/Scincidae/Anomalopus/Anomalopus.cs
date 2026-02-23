using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Anomalopus;

/// <summary>
/// Abstract class for Anomalopus (genus).
/// NCBI TaxId: 220771
/// </summary>
public abstract class Anomalopus : Scincidae, IAnomalopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anomalopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 220771;

    /// <inheritdoc />
    public virtual string GenusName => "Anomalopus";

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
