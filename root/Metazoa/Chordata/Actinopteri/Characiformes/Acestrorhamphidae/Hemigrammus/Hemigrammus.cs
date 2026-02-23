using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hemigrammus;

/// <summary>
/// Abstract class for Hemigrammus (genus).
/// NCBI TaxId: 206483
/// </summary>
public abstract class Hemigrammus : Acestrorhamphidae, IHemigrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemigrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206483;

    /// <inheritdoc />
    public virtual string GenusName => "Hemigrammus";

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
