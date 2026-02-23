using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Xenocypris;

/// <summary>
/// Abstract class for Xenocypris (genus).
/// NCBI TaxId: 70544
/// </summary>
public abstract class Xenocypris : Xenocyprididae, IXenocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70544;

    /// <inheritdoc />
    public virtual string GenusName => "Xenocypris";

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
