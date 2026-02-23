using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Deveximentum;

/// <summary>
/// Abstract class for Deveximentum (genus).
/// NCBI TaxId: 1633499
/// </summary>
public abstract class Deveximentum : Leiognathidae, IDeveximentum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deveximentum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633499;

    /// <inheritdoc />
    public virtual string GenusName => "Deveximentum";

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
