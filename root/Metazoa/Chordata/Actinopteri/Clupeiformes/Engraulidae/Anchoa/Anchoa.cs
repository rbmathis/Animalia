using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Anchoa;

/// <summary>
/// Abstract class for Anchoa (genus).
/// NCBI TaxId: 224717
/// </summary>
public abstract class Anchoa : Engraulidae, IAnchoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anchoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224717;

    /// <inheritdoc />
    public virtual string GenusName => "Anchoa";

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
