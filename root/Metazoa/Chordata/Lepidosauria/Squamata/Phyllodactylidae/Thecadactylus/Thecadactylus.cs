using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Thecadactylus;

/// <summary>
/// Abstract class for Thecadactylus (genus).
/// NCBI TaxId: 290507
/// </summary>
public abstract class Thecadactylus : Phyllodactylidae, IThecadactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thecadactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 290507;

    /// <inheritdoc />
    public virtual string GenusName => "Thecadactylus";

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
