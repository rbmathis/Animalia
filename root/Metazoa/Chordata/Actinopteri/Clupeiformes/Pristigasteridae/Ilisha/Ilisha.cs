using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae.Ilisha;

/// <summary>
/// Abstract class for Ilisha (genus).
/// NCBI TaxId: 365053
/// </summary>
public abstract class Ilisha : Pristigasteridae, IIlisha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ilisha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 365053;

    /// <inheritdoc />
    public virtual string GenusName => "Ilisha";

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
