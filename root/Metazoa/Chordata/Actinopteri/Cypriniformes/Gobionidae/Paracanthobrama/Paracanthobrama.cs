using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Paracanthobrama;

/// <summary>
/// Abstract class for Paracanthobrama (genus).
/// NCBI TaxId: 291818
/// </summary>
public abstract class Paracanthobrama : Gobionidae, IParacanthobrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracanthobrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 291818;

    /// <inheritdoc />
    public virtual string GenusName => "Paracanthobrama";

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
