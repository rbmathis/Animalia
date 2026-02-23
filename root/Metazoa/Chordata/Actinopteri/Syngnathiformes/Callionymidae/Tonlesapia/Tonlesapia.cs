using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Tonlesapia;

/// <summary>
/// Abstract class for Tonlesapia (genus).
/// NCBI TaxId: 347730
/// </summary>
public abstract class Tonlesapia : Callionymidae, ITonlesapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tonlesapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 347730;

    /// <inheritdoc />
    public virtual string GenusName => "Tonlesapia";

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
