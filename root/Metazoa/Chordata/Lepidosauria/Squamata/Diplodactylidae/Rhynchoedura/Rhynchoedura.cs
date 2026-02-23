using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Rhynchoedura;

/// <summary>
/// Abstract class for Rhynchoedura (genus).
/// NCBI TaxId: 95123
/// </summary>
public abstract class Rhynchoedura : Diplodactylidae, IRhynchoedura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchoedura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 95123;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchoedura";

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
