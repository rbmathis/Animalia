using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Xenobrama;

/// <summary>
/// Abstract class for Xenobrama (genus).
/// NCBI TaxId: 443811
/// </summary>
public abstract class Xenobrama : Bramidae, IXenobrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenobrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443811;

    /// <inheritdoc />
    public virtual string GenusName => "Xenobrama";

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
