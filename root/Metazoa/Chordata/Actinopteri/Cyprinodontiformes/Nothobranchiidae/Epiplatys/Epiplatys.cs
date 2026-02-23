using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Epiplatys;

/// <summary>
/// Abstract class for Epiplatys (genus).
/// NCBI TaxId: 52655
/// </summary>
public abstract class Epiplatys : Nothobranchiidae, IEpiplatys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epiplatys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52655;

    /// <inheritdoc />
    public virtual string GenusName => "Epiplatys";

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
