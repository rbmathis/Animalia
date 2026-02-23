using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Heurnia;

/// <summary>
/// Abstract class for Heurnia (genus).
/// NCBI TaxId: 1544987
/// </summary>
public abstract class Heurnia : Homalopsidae, IHeurnia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heurnia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544987;

    /// <inheritdoc />
    public virtual string GenusName => "Heurnia";

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
