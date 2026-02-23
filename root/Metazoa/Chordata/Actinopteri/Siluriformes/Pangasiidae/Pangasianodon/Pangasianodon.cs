using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasianodon;

/// <summary>
/// Abstract class for Pangasianodon (genus).
/// NCBI TaxId: 30992
/// </summary>
public abstract class Pangasianodon : Pangasiidae, IPangasianodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pangasianodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30992;

    /// <inheritdoc />
    public virtual string GenusName => "Pangasianodon";

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
