using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Sanguirana;

/// <summary>
/// Abstract class for Sanguirana (genus).
/// NCBI TaxId: 1208497
/// </summary>
public abstract class Sanguirana : Ranidae, ISanguirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sanguirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1208497;

    /// <inheritdoc />
    public virtual string GenusName => "Sanguirana";

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
