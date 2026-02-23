using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Fowleria;

/// <summary>
/// Abstract class for Fowleria (genus).
/// NCBI TaxId: 316377
/// </summary>
public abstract class Fowleria : Apogonidae, IFowleria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fowleria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316377;

    /// <inheritdoc />
    public virtual string GenusName => "Fowleria";

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
