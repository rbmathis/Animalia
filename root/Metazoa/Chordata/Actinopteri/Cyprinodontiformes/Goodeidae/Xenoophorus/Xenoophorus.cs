using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Xenoophorus;

/// <summary>
/// Abstract class for Xenoophorus (genus).
/// NCBI TaxId: 208355
/// </summary>
public abstract class Xenoophorus : Goodeidae, IXenoophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenoophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208355;

    /// <inheritdoc />
    public virtual string GenusName => "Xenoophorus";

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
