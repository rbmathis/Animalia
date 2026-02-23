using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bathyuroconger;

/// <summary>
/// Abstract class for Bathyuroconger (genus).
/// NCBI TaxId: 391201
/// </summary>
public abstract class Bathyuroconger : Congridae, IBathyuroconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathyuroconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391201;

    /// <inheritdoc />
    public virtual string GenusName => "Bathyuroconger";

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
