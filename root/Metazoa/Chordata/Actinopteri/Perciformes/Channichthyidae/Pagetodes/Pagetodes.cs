using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Pagetodes;

/// <summary>
/// Abstract class for Pagetodes (genus).
/// NCBI TaxId: 3363447
/// </summary>
public abstract class Pagetodes : Channichthyidae, IPagetodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pagetodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363447;

    /// <inheritdoc />
    public virtual string GenusName => "Pagetodes";

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
