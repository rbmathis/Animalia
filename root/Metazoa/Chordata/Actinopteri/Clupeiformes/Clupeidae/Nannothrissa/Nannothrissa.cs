using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Nannothrissa;

/// <summary>
/// Abstract class for Nannothrissa (genus).
/// NCBI TaxId: 2998574
/// </summary>
public abstract class Nannothrissa : Clupeidae, INannothrissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannothrissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2998574;

    /// <inheritdoc />
    public virtual string GenusName => "Nannothrissa";

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
