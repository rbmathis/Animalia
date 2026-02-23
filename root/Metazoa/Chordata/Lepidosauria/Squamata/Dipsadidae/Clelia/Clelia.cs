using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Clelia;

/// <summary>
/// Abstract class for Clelia (genus).
/// NCBI TaxId: 121321
/// </summary>
public abstract class Clelia : Dipsadidae, IClelia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clelia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121321;

    /// <inheritdoc />
    public virtual string GenusName => "Clelia";

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
