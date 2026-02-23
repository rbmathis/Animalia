using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Osteobrama;

/// <summary>
/// Abstract class for Osteobrama (genus).
/// NCBI TaxId: 209195
/// </summary>
public abstract class Osteobrama : Cyprinidae, IOsteobrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osteobrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209195;

    /// <inheritdoc />
    public virtual string GenusName => "Osteobrama";

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
