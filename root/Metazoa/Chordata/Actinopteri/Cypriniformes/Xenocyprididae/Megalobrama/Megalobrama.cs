using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Megalobrama;

/// <summary>
/// Abstract class for Megalobrama (genus).
/// NCBI TaxId: 75351
/// </summary>
public abstract class Megalobrama : Xenocyprididae, IMegalobrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalobrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75351;

    /// <inheritdoc />
    public virtual string GenusName => "Megalobrama";

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
