using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Episemion;

/// <summary>
/// Abstract class for Episemion (genus).
/// NCBI TaxId: 406274
/// </summary>
public abstract class Episemion : Nothobranchiidae, IEpisemion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Episemion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 406274;

    /// <inheritdoc />
    public virtual string GenusName => "Episemion";

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
