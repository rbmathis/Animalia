using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Foerschichthys;

/// <summary>
/// Abstract class for Foerschichthys (genus).
/// NCBI TaxId: 60309
/// </summary>
public abstract class Foerschichthys : Nothobranchiidae, IFoerschichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Foerschichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 60309;

    /// <inheritdoc />
    public virtual string GenusName => "Foerschichthys";

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
