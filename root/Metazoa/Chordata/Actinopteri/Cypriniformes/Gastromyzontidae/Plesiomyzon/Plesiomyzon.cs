using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Plesiomyzon;

/// <summary>
/// Abstract class for Plesiomyzon (genus).
/// NCBI TaxId: 1435193
/// </summary>
public abstract class Plesiomyzon : Gastromyzontidae, IPlesiomyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plesiomyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1435193;

    /// <inheritdoc />
    public virtual string GenusName => "Plesiomyzon";

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
