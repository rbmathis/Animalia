using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Kneria;

/// <summary>
/// Abstract class for Kneria (genus).
/// NCBI TaxId: 42622
/// </summary>
public abstract class Kneria : Kneriidae, IKneria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kneria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42622;

    /// <inheritdoc />
    public virtual string GenusName => "Kneria";

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
