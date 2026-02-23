using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Goggia;

/// <summary>
/// Abstract class for Goggia (genus).
/// NCBI TaxId: 221559
/// </summary>
public abstract class Goggia : Gekkonidae, IGoggia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Goggia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221559;

    /// <inheritdoc />
    public virtual string GenusName => "Goggia";

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
