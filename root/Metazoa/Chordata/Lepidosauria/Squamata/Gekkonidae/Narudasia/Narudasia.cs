using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Narudasia;

/// <summary>
/// Abstract class for Narudasia (genus).
/// NCBI TaxId: 221571
/// </summary>
public abstract class Narudasia : Gekkonidae, INarudasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Narudasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221571;

    /// <inheritdoc />
    public virtual string GenusName => "Narudasia";

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
