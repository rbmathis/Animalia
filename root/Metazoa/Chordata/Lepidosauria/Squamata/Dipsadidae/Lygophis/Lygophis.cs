using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Lygophis;

/// <summary>
/// Abstract class for Lygophis (genus).
/// NCBI TaxId: 1159288
/// </summary>
public abstract class Lygophis : Dipsadidae, ILygophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lygophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1159288;

    /// <inheritdoc />
    public virtual string GenusName => "Lygophis";

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
