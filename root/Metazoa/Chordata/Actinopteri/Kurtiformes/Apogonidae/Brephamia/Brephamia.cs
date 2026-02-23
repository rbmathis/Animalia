using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Brephamia;

/// <summary>
/// Abstract class for Brephamia (genus).
/// NCBI TaxId: 1431504
/// </summary>
public abstract class Brephamia : Apogonidae, IBrephamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brephamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1431504;

    /// <inheritdoc />
    public virtual string GenusName => "Brephamia";

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
