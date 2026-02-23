using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Oregonichthys;

/// <summary>
/// Abstract class for Oregonichthys (genus).
/// NCBI TaxId: 86925
/// </summary>
public abstract class Oregonichthys : Leuciscidae, IOregonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oregonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86925;

    /// <inheritdoc />
    public virtual string GenusName => "Oregonichthys";

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
