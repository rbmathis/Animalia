using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Alpinoscincus;

/// <summary>
/// Abstract class for Alpinoscincus (genus).
/// NCBI TaxId: 2878436
/// </summary>
public abstract class Alpinoscincus : Scincidae, IAlpinoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alpinoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878436;

    /// <inheritdoc />
    public virtual string GenusName => "Alpinoscincus";

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
