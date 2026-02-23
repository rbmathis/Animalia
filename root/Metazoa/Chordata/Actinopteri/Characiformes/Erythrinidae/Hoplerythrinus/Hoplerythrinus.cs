using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae.Hoplerythrinus;

/// <summary>
/// Abstract class for Hoplerythrinus (genus).
/// NCBI TaxId: 756481
/// </summary>
public abstract class Hoplerythrinus : Erythrinidae, IHoplerythrinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplerythrinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 756481;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplerythrinus";

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
