using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Wallaceophis;

/// <summary>
/// Abstract class for Wallaceophis (genus).
/// NCBI TaxId: 1819669
/// </summary>
public abstract class Wallaceophis : Colubridae, IWallaceophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wallaceophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1819669;

    /// <inheritdoc />
    public virtual string GenusName => "Wallaceophis";

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
