using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Isthmohyla;

/// <summary>
/// Abstract class for Isthmohyla (genus).
/// NCBI TaxId: 374083
/// </summary>
public abstract class Isthmohyla : Hylidae, IIsthmohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isthmohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374083;

    /// <inheritdoc />
    public virtual string GenusName => "Isthmohyla";

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
