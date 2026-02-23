using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae.Pellona;

/// <summary>
/// Abstract class for Pellona (genus).
/// NCBI TaxId: 260505
/// </summary>
public abstract class Pellona : Pristigasteridae, IPellona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pellona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 260505;

    /// <inheritdoc />
    public virtual string GenusName => "Pellona";

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
