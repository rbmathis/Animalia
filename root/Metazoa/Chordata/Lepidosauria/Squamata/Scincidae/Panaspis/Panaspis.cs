using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Panaspis;

/// <summary>
/// Abstract class for Panaspis (genus).
/// NCBI TaxId: 245650
/// </summary>
public abstract class Panaspis : Scincidae, IPanaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Panaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245650;

    /// <inheritdoc />
    public virtual string GenusName => "Panaspis";

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
