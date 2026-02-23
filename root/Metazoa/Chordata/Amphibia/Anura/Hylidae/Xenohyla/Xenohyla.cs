using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Xenohyla;

/// <summary>
/// Abstract class for Xenohyla (genus).
/// NCBI TaxId: 318414
/// </summary>
public abstract class Xenohyla : Hylidae, IXenohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318414;

    /// <inheritdoc />
    public virtual string GenusName => "Xenohyla";

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
