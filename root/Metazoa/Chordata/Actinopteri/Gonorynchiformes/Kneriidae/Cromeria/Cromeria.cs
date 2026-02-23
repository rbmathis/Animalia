using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Cromeria;

/// <summary>
/// Abstract class for Cromeria (genus).
/// NCBI TaxId: 299316
/// </summary>
public abstract class Cromeria : Kneriidae, ICromeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cromeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 299316;

    /// <inheritdoc />
    public virtual string GenusName => "Cromeria";

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
