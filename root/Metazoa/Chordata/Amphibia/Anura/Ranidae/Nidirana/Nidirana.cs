using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Nidirana;

/// <summary>
/// Abstract class for Nidirana (genus).
/// NCBI TaxId: 2054187
/// </summary>
public abstract class Nidirana : Ranidae, INidirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nidirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2054187;

    /// <inheritdoc />
    public virtual string GenusName => "Nidirana";

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
