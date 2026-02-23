using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Indosylvirana;

/// <summary>
/// Abstract class for Indosylvirana (genus).
/// NCBI TaxId: 1659765
/// </summary>
public abstract class Indosylvirana : Ranidae, IIndosylvirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indosylvirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1659765;

    /// <inheritdoc />
    public virtual string GenusName => "Indosylvirana";

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
