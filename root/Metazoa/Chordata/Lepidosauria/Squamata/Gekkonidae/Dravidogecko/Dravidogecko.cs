using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Dravidogecko;

/// <summary>
/// Abstract class for Dravidogecko (genus).
/// NCBI TaxId: 2651357
/// </summary>
public abstract class Dravidogecko : Gekkonidae, IDravidogecko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dravidogecko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2651357;

    /// <inheritdoc />
    public virtual string GenusName => "Dravidogecko";

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
