using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Fibramia;

/// <summary>
/// Abstract class for Fibramia (genus).
/// NCBI TaxId: 1604642
/// </summary>
public abstract class Fibramia : Apogonidae, IFibramia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fibramia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1604642;

    /// <inheritdoc />
    public virtual string GenusName => "Fibramia";

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
