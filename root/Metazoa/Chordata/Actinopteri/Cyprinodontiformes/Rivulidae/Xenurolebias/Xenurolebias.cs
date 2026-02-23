using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Xenurolebias;

/// <summary>
/// Abstract class for Xenurolebias (genus).
/// NCBI TaxId: 941676
/// </summary>
public abstract class Xenurolebias : Rivulidae, IXenurolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenurolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 941676;

    /// <inheritdoc />
    public virtual string GenusName => "Xenurolebias";

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
