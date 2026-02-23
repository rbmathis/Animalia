using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Paraluteres;

/// <summary>
/// Abstract class for Paraluteres (genus).
/// NCBI TaxId: 303717
/// </summary>
public abstract class Paraluteres : Monacanthidae, IParaluteres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraluteres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303717;

    /// <inheritdoc />
    public virtual string GenusName => "Paraluteres";

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
