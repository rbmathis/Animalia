using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Acreichthys;

/// <summary>
/// Abstract class for Acreichthys (genus).
/// NCBI TaxId: 392909
/// </summary>
public abstract class Acreichthys : Monacanthidae, IAcreichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acreichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392909;

    /// <inheritdoc />
    public virtual string GenusName => "Acreichthys";

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
