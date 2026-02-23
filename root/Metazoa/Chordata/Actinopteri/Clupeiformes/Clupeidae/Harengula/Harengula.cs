using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Harengula;

/// <summary>
/// Abstract class for Harengula (genus).
/// NCBI TaxId: 224704
/// </summary>
public abstract class Harengula : Clupeidae, IHarengula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harengula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224704;

    /// <inheritdoc />
    public virtual string GenusName => "Harengula";

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
