using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Floridichthys;

/// <summary>
/// Abstract class for Floridichthys (genus).
/// NCBI TaxId: 30741
/// </summary>
public abstract class Floridichthys : Cyprinodontidae, IFloridichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Floridichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30741;

    /// <inheritdoc />
    public virtual string GenusName => "Floridichthys";

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
