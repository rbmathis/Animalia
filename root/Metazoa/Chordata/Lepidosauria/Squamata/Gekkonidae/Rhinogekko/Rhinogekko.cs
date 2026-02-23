using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Rhinogekko;

/// <summary>
/// Abstract class for Rhinogekko (genus).
/// NCBI TaxId: 2600258
/// </summary>
public abstract class Rhinogekko : Gekkonidae, IRhinogekko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinogekko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2600258;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinogekko";

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
