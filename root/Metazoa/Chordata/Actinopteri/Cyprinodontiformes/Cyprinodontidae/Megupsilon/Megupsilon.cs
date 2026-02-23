using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Megupsilon;

/// <summary>
/// Abstract class for Megupsilon (genus).
/// NCBI TaxId: 30745
/// </summary>
public abstract class Megupsilon : Cyprinodontidae, IMegupsilon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megupsilon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30745;

    /// <inheritdoc />
    public virtual string GenusName => "Megupsilon";

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
