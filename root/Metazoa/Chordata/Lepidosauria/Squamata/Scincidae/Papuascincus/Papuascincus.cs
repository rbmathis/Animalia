using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Papuascincus;

/// <summary>
/// Abstract class for Papuascincus (genus).
/// NCBI TaxId: 405199
/// </summary>
public abstract class Papuascincus : Scincidae, IPapuascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Papuascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 405199;

    /// <inheritdoc />
    public virtual string GenusName => "Papuascincus";

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
