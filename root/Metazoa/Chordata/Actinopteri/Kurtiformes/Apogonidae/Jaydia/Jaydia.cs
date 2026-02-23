using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Jaydia;

/// <summary>
/// Abstract class for Jaydia (genus).
/// NCBI TaxId: 1604641
/// </summary>
public abstract class Jaydia : Apogonidae, IJaydia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jaydia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1604641;

    /// <inheritdoc />
    public virtual string GenusName => "Jaydia";

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
