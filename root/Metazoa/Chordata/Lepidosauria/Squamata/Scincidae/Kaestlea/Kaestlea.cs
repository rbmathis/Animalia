using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Kaestlea;

/// <summary>
/// Abstract class for Kaestlea (genus).
/// NCBI TaxId: 1485967
/// </summary>
public abstract class Kaestlea : Scincidae, IKaestlea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kaestlea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1485967;

    /// <inheritdoc />
    public virtual string GenusName => "Kaestlea";

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
