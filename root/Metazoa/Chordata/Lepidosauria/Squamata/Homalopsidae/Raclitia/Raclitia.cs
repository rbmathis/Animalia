using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Raclitia;

/// <summary>
/// Abstract class for Raclitia (genus).
/// NCBI TaxId: 2488876
/// </summary>
public abstract class Raclitia : Homalopsidae, IRaclitia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Raclitia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2488876;

    /// <inheritdoc />
    public virtual string GenusName => "Raclitia";

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
