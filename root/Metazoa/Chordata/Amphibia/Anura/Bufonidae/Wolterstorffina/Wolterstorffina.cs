using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Wolterstorffina;

/// <summary>
/// Abstract class for Wolterstorffina (genus).
/// NCBI TaxId: 356338
/// </summary>
public abstract class Wolterstorffina : Bufonidae, IWolterstorffina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wolterstorffina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356338;

    /// <inheritdoc />
    public virtual string GenusName => "Wolterstorffina";

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
