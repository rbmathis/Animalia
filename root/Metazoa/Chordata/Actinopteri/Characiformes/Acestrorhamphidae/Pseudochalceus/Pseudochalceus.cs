using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Pseudochalceus;

/// <summary>
/// Abstract class for Pseudochalceus (genus).
/// NCBI TaxId: 883874
/// </summary>
public abstract class Pseudochalceus : Acestrorhamphidae, IPseudochalceus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudochalceus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 883874;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudochalceus";

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
