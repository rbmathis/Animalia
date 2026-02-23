using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Dorosoma;

/// <summary>
/// Abstract class for Dorosoma (genus).
/// NCBI TaxId: 224712
/// </summary>
public abstract class Dorosoma : Clupeidae, IDorosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dorosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224712;

    /// <inheritdoc />
    public virtual string GenusName => "Dorosoma";

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
