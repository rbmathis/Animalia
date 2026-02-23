using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Okamejei;

/// <summary>
/// Abstract class for Okamejei (genus).
/// NCBI TaxId: 117864
/// </summary>
public abstract class Okamejei : Rajidae, IOkamejei
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Okamejei";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117864;

    /// <inheritdoc />
    public virtual string GenusName => "Okamejei";

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
