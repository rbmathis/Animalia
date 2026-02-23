using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Brachychalcinus;

/// <summary>
/// Abstract class for Brachychalcinus (genus).
/// NCBI TaxId: 930302
/// </summary>
public abstract class Brachychalcinus : Acestrorhamphidae, IBrachychalcinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachychalcinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930302;

    /// <inheritdoc />
    public virtual string GenusName => "Brachychalcinus";

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
