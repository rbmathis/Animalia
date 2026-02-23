using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Brachyorrhos;

/// <summary>
/// Abstract class for Brachyorrhos (genus).
/// NCBI TaxId: 1229960
/// </summary>
public abstract class Brachyorrhos : Homalopsidae, IBrachyorrhos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyorrhos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1229960;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyorrhos";

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
