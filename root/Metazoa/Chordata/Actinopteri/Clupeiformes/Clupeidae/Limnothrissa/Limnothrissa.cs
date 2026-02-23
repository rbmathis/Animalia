using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Limnothrissa;

/// <summary>
/// Abstract class for Limnothrissa (genus).
/// NCBI TaxId: 55123
/// </summary>
public abstract class Limnothrissa : Clupeidae, ILimnothrissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnothrissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55123;

    /// <inheritdoc />
    public virtual string GenusName => "Limnothrissa";

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
