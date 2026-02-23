using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Toxicocalamus;

/// <summary>
/// Abstract class for Toxicocalamus (genus).
/// NCBI TaxId: 66181
/// </summary>
public abstract class Toxicocalamus : Elapidae, IToxicocalamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Toxicocalamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66181;

    /// <inheritdoc />
    public virtual string GenusName => "Toxicocalamus";

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
