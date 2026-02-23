using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Synophis;

/// <summary>
/// Abstract class for Synophis (genus).
/// NCBI TaxId: 1212734
/// </summary>
public abstract class Synophis : Dipsadidae, ISynophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1212734;

    /// <inheritdoc />
    public virtual string GenusName => "Synophis";

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
