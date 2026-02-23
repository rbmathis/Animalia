using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Aphyosemion;

/// <summary>
/// Abstract class for Aphyosemion (genus).
/// NCBI TaxId: 52652
/// </summary>
public abstract class Aphyosemion : Nothobranchiidae, IAphyosemion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphyosemion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52652;

    /// <inheritdoc />
    public virtual string GenusName => "Aphyosemion";

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
