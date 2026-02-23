using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Xenobalistes;

/// <summary>
/// Abstract class for Xenobalistes (genus).
/// NCBI TaxId: 388624
/// </summary>
public abstract class Xenobalistes : Balistidae, IXenobalistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenobalistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 388624;

    /// <inheritdoc />
    public virtual string GenusName => "Xenobalistes";

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
