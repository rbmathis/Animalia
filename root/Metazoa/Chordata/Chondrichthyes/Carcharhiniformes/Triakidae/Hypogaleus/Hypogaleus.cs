using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Hypogaleus;

/// <summary>
/// Abstract class for Hypogaleus (genus).
/// NCBI TaxId: 376652
/// </summary>
public abstract class Hypogaleus : Triakidae, IHypogaleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypogaleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376652;

    /// <inheritdoc />
    public virtual string GenusName => "Hypogaleus";

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
