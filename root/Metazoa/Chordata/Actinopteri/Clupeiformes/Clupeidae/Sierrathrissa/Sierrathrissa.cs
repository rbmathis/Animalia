using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sierrathrissa;

/// <summary>
/// Abstract class for Sierrathrissa (genus).
/// NCBI TaxId: 521042
/// </summary>
public abstract class Sierrathrissa : Clupeidae, ISierrathrissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sierrathrissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 521042;

    /// <inheritdoc />
    public virtual string GenusName => "Sierrathrissa";

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
