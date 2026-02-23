using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Pituna;

/// <summary>
/// Abstract class for Pituna (genus).
/// NCBI TaxId: 61828
/// </summary>
public abstract class Pituna : Rivulidae, IPituna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pituna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61828;

    /// <inheritdoc />
    public virtual string GenusName => "Pituna";

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
