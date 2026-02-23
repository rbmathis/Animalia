using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Hyperlophus;

/// <summary>
/// Abstract class for Hyperlophus (genus).
/// NCBI TaxId: 521030
/// </summary>
public abstract class Hyperlophus : Clupeidae, IHyperlophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyperlophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 521030;

    /// <inheritdoc />
    public virtual string GenusName => "Hyperlophus";

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
