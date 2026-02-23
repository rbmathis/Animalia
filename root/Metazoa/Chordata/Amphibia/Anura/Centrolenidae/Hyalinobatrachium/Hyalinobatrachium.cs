using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Hyalinobatrachium;

/// <summary>
/// Abstract class for Hyalinobatrachium (genus).
/// NCBI TaxId: 192744
/// </summary>
public abstract class Hyalinobatrachium : Centrolenidae, IHyalinobatrachium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyalinobatrachium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192744;

    /// <inheritdoc />
    public virtual string GenusName => "Hyalinobatrachium";

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
