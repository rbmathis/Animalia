using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Amnirana;

/// <summary>
/// Abstract class for Amnirana (genus).
/// NCBI TaxId: 2067478
/// </summary>
public abstract class Amnirana : Ranidae, IAmnirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amnirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2067478;

    /// <inheritdoc />
    public virtual string GenusName => "Amnirana";

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
