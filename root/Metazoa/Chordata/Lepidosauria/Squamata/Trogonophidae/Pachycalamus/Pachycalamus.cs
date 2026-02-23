using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Trogonophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Trogonophidae.Pachycalamus;

/// <summary>
/// Abstract class for Pachycalamus (genus).
/// NCBI TaxId: 1545050
/// </summary>
public abstract class Pachycalamus : Trogonophidae, IPachycalamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachycalamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545050;

    /// <inheritdoc />
    public virtual string GenusName => "Pachycalamus";

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
