using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae.Atractosteus;

/// <summary>
/// Abstract class for Atractosteus (genus).
/// NCBI TaxId: 512340
/// </summary>
public abstract class Atractosteus : Lepisosteidae, IAtractosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atractosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 512340;

    /// <inheritdoc />
    public virtual string GenusName => "Atractosteus";

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
