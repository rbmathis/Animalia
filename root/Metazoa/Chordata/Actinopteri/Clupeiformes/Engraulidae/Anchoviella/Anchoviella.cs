using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Anchoviella;

/// <summary>
/// Abstract class for Anchoviella (genus).
/// NCBI TaxId: 435133
/// </summary>
public abstract class Anchoviella : Engraulidae, IAnchoviella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anchoviella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 435133;

    /// <inheritdoc />
    public virtual string GenusName => "Anchoviella";

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
