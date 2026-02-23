using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Brachyurophis;

/// <summary>
/// Abstract class for Brachyurophis (genus).
/// NCBI TaxId: 529683
/// </summary>
public abstract class Brachyurophis : Elapidae, IBrachyurophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyurophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 529683;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyurophis";

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
