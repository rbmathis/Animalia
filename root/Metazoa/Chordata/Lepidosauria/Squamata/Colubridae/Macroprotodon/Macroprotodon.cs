using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Macroprotodon;

/// <summary>
/// Abstract class for Macroprotodon (genus).
/// NCBI TaxId: 186553
/// </summary>
public abstract class Macroprotodon : Colubridae, IMacroprotodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macroprotodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186553;

    /// <inheritdoc />
    public virtual string GenusName => "Macroprotodon";

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
