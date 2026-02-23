using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Pronothobranchius;

/// <summary>
/// Abstract class for Pronothobranchius (genus).
/// NCBI TaxId: 60305
/// </summary>
public abstract class Pronothobranchius : Nothobranchiidae, IPronothobranchius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pronothobranchius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 60305;

    /// <inheritdoc />
    public virtual string GenusName => "Pronothobranchius";

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
