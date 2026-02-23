using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Pseudogekko;

/// <summary>
/// Abstract class for Pseudogekko (genus).
/// NCBI TaxId: 1183065
/// </summary>
public abstract class Pseudogekko : Gekkonidae, IPseudogekko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudogekko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1183065;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudogekko";

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
