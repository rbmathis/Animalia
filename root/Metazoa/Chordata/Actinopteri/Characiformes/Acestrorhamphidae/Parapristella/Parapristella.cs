using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Parapristella;

/// <summary>
/// Abstract class for Parapristella (genus).
/// NCBI TaxId: 2608187
/// </summary>
public abstract class Parapristella : Acestrorhamphidae, IParapristella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parapristella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608187;

    /// <inheritdoc />
    public virtual string GenusName => "Parapristella";

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
