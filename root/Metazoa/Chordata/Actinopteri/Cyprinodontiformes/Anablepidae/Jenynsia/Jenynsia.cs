using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Anablepidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Anablepidae.Jenynsia;

/// <summary>
/// Abstract class for Jenynsia (genus).
/// NCBI TaxId: 28766
/// </summary>
public abstract class Jenynsia : Anablepidae, IJenynsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jenynsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28766;

    /// <inheritdoc />
    public virtual string GenusName => "Jenynsia";

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
