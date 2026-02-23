using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Madascincus;

/// <summary>
/// Abstract class for Madascincus (genus).
/// NCBI TaxId: 665121
/// </summary>
public abstract class Madascincus : Scincidae, IMadascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Madascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 665121;

    /// <inheritdoc />
    public virtual string GenusName => "Madascincus";

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
