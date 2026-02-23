using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Xenotaenia;

/// <summary>
/// Abstract class for Xenotaenia (genus).
/// NCBI TaxId: 208357
/// </summary>
public abstract class Xenotaenia : Goodeidae, IXenotaenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenotaenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208357;

    /// <inheritdoc />
    public virtual string GenusName => "Xenotaenia";

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
