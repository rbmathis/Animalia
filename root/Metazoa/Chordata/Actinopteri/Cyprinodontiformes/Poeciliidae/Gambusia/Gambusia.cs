using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Gambusia;

/// <summary>
/// Abstract class for Gambusia (genus).
/// NCBI TaxId: 33527
/// </summary>
public abstract class Gambusia : Poeciliidae, IGambusia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gambusia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33527;

    /// <inheritdoc />
    public virtual string GenusName => "Gambusia";

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
