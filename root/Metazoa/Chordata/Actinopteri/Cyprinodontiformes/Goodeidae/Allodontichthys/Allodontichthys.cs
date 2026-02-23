using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Allodontichthys;

/// <summary>
/// Abstract class for Allodontichthys (genus).
/// NCBI TaxId: 208307
/// </summary>
public abstract class Allodontichthys : Goodeidae, IAllodontichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allodontichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208307;

    /// <inheritdoc />
    public virtual string GenusName => "Allodontichthys";

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
