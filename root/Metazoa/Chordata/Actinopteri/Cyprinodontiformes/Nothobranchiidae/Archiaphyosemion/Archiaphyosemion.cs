using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Archiaphyosemion;

/// <summary>
/// Abstract class for Archiaphyosemion (genus).
/// NCBI TaxId: 130717
/// </summary>
public abstract class Archiaphyosemion : Nothobranchiidae, IArchiaphyosemion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archiaphyosemion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 130717;

    /// <inheritdoc />
    public virtual string GenusName => "Archiaphyosemion";

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
