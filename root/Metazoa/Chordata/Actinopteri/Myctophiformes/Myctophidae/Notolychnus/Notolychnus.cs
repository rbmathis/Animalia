using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Notolychnus;

/// <summary>
/// Abstract class for Notolychnus (genus).
/// NCBI TaxId: 123231
/// </summary>
public abstract class Notolychnus : Myctophidae, INotolychnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notolychnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123231;

    /// <inheritdoc />
    public virtual string GenusName => "Notolychnus";

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
