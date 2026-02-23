using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Glyptodon;

/// <summary>
/// Abstract class for Glyptodon (genus).
/// NCBI TaxId: 2546652
/// </summary>
public abstract class Glyptodon : Chlamyphoridae, IGlyptodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyptodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546652;

    /// <inheritdoc />
    public virtual string GenusName => "Glyptodon";

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
