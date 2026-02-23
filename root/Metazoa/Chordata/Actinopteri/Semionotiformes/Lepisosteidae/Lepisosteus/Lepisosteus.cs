using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae.Lepisosteus;

/// <summary>
/// Abstract class for Lepisosteus (genus).
/// NCBI TaxId: 7916
/// </summary>
public abstract class Lepisosteus : Lepisosteidae, ILepisosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepisosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7916;

    /// <inheritdoc />
    public virtual string GenusName => "Lepisosteus";

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
