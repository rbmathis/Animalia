using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Allotoca;

/// <summary>
/// Abstract class for Allotoca (genus).
/// NCBI TaxId: 208314
/// </summary>
public abstract class Allotoca : Goodeidae, IAllotoca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allotoca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208314;

    /// <inheritdoc />
    public virtual string GenusName => "Allotoca";

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
