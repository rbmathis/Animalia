using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Pseudobrama;

/// <summary>
/// Abstract class for Pseudobrama (genus).
/// NCBI TaxId: 70550
/// </summary>
public abstract class Pseudobrama : Xenocyprididae, IPseudobrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70550;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobrama";

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
