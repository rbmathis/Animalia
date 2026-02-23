using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Microthrissa;

/// <summary>
/// Abstract class for Microthrissa (genus).
/// NCBI TaxId: 521032
/// </summary>
public abstract class Microthrissa : Clupeidae, IMicrothrissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microthrissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 521032;

    /// <inheritdoc />
    public virtual string GenusName => "Microthrissa";

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
