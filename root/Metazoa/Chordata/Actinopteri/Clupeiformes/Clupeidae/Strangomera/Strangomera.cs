using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Strangomera;

/// <summary>
/// Abstract class for Strangomera (genus).
/// NCBI TaxId: 249025
/// </summary>
public abstract class Strangomera : Clupeidae, IStrangomera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strangomera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 249025;

    /// <inheritdoc />
    public virtual string GenusName => "Strangomera";

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
