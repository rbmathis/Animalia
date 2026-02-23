using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Cubanichthys;

/// <summary>
/// Abstract class for Cubanichthys (genus).
/// NCBI TaxId: 28739
/// </summary>
public abstract class Cubanichthys : Cyprinodontidae, ICubanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cubanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28739;

    /// <inheritdoc />
    public virtual string GenusName => "Cubanichthys";

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
