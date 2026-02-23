using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae.Dendrogale;

/// <summary>
/// Abstract class for Dendrogale (genus).
/// NCBI TaxId: 246552
/// </summary>
public abstract class Dendrogale : Tupaiidae, IDendrogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 246552;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrogale";

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
