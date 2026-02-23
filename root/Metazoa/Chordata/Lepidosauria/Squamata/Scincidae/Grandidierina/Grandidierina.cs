using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Grandidierina;

/// <summary>
/// Abstract class for Grandidierina (genus).
/// NCBI TaxId: 2025381
/// </summary>
public abstract class Grandidierina : Scincidae, IGrandidierina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grandidierina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2025381;

    /// <inheritdoc />
    public virtual string GenusName => "Grandidierina";

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
