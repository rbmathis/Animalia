using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Acanthobrama;

/// <summary>
/// Abstract class for Acanthobrama (genus).
/// NCBI TaxId: 155069
/// </summary>
public abstract class Acanthobrama : Leuciscidae, IAcanthobrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthobrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 155069;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthobrama";

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
