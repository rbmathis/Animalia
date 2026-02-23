using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Chalcidoseps;

/// <summary>
/// Abstract class for Chalcidoseps (genus).
/// NCBI TaxId: 1543978
/// </summary>
public abstract class Chalcidoseps : Scincidae, IChalcidoseps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalcidoseps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1543978;

    /// <inheritdoc />
    public virtual string GenusName => "Chalcidoseps";

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
