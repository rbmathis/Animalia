using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Lophostoma;

/// <summary>
/// Abstract class for Lophostoma (genus).
/// NCBI TaxId: 263450
/// </summary>
public abstract class Lophostoma : Phyllostomidae, ILophostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 263450;

    /// <inheritdoc />
    public virtual string GenusName => "Lophostoma";

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
