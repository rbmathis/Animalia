using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Pagetopsis;

/// <summary>
/// Abstract class for Pagetopsis (genus).
/// NCBI TaxId: 36193
/// </summary>
public abstract class Pagetopsis : Channichthyidae, IPagetopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pagetopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36193;

    /// <inheritdoc />
    public virtual string GenusName => "Pagetopsis";

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
