using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Jordanella;

/// <summary>
/// Abstract class for Jordanella (genus).
/// NCBI TaxId: 28744
/// </summary>
public abstract class Jordanella : Cyprinodontidae, IJordanella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jordanella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28744;

    /// <inheritdoc />
    public virtual string GenusName => "Jordanella";

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
