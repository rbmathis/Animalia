using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Uroconger;

/// <summary>
/// Abstract class for Uroconger (genus).
/// NCBI TaxId: 189924
/// </summary>
public abstract class Uroconger : Congridae, IUroconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uroconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189924;

    /// <inheritdoc />
    public virtual string GenusName => "Uroconger";

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
