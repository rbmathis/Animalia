using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Tantilla;

/// <summary>
/// Abstract class for Tantilla (genus).
/// NCBI TaxId: 121369
/// </summary>
public abstract class Tantilla : Colubridae, ITantilla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tantilla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121369;

    /// <inheritdoc />
    public virtual string GenusName => "Tantilla";

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
