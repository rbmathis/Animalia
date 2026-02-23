using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Acanthaluteres;

/// <summary>
/// Abstract class for Acanthaluteres (genus).
/// NCBI TaxId: 392907
/// </summary>
public abstract class Acanthaluteres : Monacanthidae, IAcanthaluteres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthaluteres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392907;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthaluteres";

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
