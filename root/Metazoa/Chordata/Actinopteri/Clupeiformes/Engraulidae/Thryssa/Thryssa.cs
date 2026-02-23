using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Thryssa;

/// <summary>
/// Abstract class for Thryssa (genus).
/// NCBI TaxId: 435228
/// </summary>
public abstract class Thryssa : Engraulidae, IThryssa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thryssa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 435228;

    /// <inheritdoc />
    public virtual string GenusName => "Thryssa";

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
