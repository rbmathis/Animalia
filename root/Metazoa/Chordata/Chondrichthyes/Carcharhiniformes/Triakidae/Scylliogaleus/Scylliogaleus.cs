using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Scylliogaleus;

/// <summary>
/// Abstract class for Scylliogaleus (genus).
/// NCBI TaxId: 376655
/// </summary>
public abstract class Scylliogaleus : Triakidae, IScylliogaleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scylliogaleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376655;

    /// <inheritdoc />
    public virtual string GenusName => "Scylliogaleus";

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
