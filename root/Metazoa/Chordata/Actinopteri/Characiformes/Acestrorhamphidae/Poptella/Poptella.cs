using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Poptella;

/// <summary>
/// Abstract class for Poptella (genus).
/// NCBI TaxId: 42596
/// </summary>
public abstract class Poptella : Acestrorhamphidae, IPoptella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poptella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42596;

    /// <inheritdoc />
    public virtual string GenusName => "Poptella";

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
