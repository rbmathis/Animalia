using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Aluterus;

/// <summary>
/// Abstract class for Aluterus (genus).
/// NCBI TaxId: 303709
/// </summary>
public abstract class Aluterus : Monacanthidae, IAluterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aluterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303709;

    /// <inheritdoc />
    public virtual string GenusName => "Aluterus";

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
