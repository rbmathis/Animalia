using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae.Pristigaster;

/// <summary>
/// Abstract class for Pristigaster (genus).
/// NCBI TaxId: 691802
/// </summary>
public abstract class Pristigaster : Pristigasteridae, IPristigaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristigaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 691802;

    /// <inheritdoc />
    public virtual string GenusName => "Pristigaster";

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
