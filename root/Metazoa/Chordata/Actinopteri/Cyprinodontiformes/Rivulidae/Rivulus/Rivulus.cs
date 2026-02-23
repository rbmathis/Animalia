using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Rivulus;

/// <summary>
/// Abstract class for Rivulus (genus).
/// NCBI TaxId: 28774
/// </summary>
public abstract class Rivulus : Rivulidae, IRivulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rivulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28774;

    /// <inheritdoc />
    public virtual string GenusName => "Rivulus";

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
