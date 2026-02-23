using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Epibator;

/// <summary>
/// Abstract class for Epibator (genus).
/// NCBI TaxId: 2025340
/// </summary>
public abstract class Epibator : Scincidae, IEpibator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epibator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2025340;

    /// <inheritdoc />
    public virtual string GenusName => "Epibator";

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
