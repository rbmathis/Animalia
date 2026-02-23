using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Anacanthus;

/// <summary>
/// Abstract class for Anacanthus (genus).
/// NCBI TaxId: 570930
/// </summary>
public abstract class Anacanthus : Monacanthidae, IAnacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 570930;

    /// <inheritdoc />
    public virtual string GenusName => "Anacanthus";

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
