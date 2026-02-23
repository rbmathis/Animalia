using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Austrelaps;

/// <summary>
/// Abstract class for Austrelaps (genus).
/// NCBI TaxId: 29155
/// </summary>
public abstract class Austrelaps : Elapidae, IAustrelaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austrelaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29155;

    /// <inheritdoc />
    public virtual string GenusName => "Austrelaps";

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
