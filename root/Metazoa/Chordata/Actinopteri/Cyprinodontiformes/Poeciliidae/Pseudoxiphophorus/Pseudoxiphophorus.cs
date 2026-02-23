using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Pseudoxiphophorus;

/// <summary>
/// Abstract class for Pseudoxiphophorus (genus).
/// NCBI TaxId: 1260735
/// </summary>
public abstract class Pseudoxiphophorus : Poeciliidae, IPseudoxiphophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoxiphophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1260735;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoxiphophorus";

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
