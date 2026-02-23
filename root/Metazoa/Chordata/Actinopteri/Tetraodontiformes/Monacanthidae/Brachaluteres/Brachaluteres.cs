using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Brachaluteres;

/// <summary>
/// Abstract class for Brachaluteres (genus).
/// NCBI TaxId: 303719
/// </summary>
public abstract class Brachaluteres : Monacanthidae, IBrachaluteres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachaluteres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303719;

    /// <inheritdoc />
    public virtual string GenusName => "Brachaluteres";

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
