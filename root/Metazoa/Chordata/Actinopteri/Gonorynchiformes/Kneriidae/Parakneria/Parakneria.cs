using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Parakneria;

/// <summary>
/// Abstract class for Parakneria (genus).
/// NCBI TaxId: 42624
/// </summary>
public abstract class Parakneria : Kneriidae, IParakneria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parakneria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42624;

    /// <inheritdoc />
    public virtual string GenusName => "Parakneria";

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
