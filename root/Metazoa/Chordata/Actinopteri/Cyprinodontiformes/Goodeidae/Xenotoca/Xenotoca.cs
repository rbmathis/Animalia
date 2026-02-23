using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Xenotoca;

/// <summary>
/// Abstract class for Xenotoca (genus).
/// NCBI TaxId: 28761
/// </summary>
public abstract class Xenotoca : Goodeidae, IXenotoca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenotoca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28761;

    /// <inheritdoc />
    public virtual string GenusName => "Xenotoca";

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
