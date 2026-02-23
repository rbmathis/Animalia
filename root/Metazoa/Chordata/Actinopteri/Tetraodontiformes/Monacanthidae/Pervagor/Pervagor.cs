using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Pervagor;

/// <summary>
/// Abstract class for Pervagor (genus).
/// NCBI TaxId: 392924
/// </summary>
public abstract class Pervagor : Monacanthidae, IPervagor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pervagor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392924;

    /// <inheritdoc />
    public virtual string GenusName => "Pervagor";

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
