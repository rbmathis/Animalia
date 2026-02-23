using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Geckolepis;

/// <summary>
/// Abstract class for Geckolepis (genus).
/// NCBI TaxId: 476475
/// </summary>
public abstract class Geckolepis : Gekkonidae, IGeckolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geckolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 476475;

    /// <inheritdoc />
    public virtual string GenusName => "Geckolepis";

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
