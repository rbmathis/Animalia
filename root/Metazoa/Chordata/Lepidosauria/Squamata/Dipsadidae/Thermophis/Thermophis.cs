using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Thermophis;

/// <summary>
/// Abstract class for Thermophis (genus).
/// NCBI TaxId: 527826
/// </summary>
public abstract class Thermophis : Dipsadidae, IThermophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thermophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 527826;

    /// <inheritdoc />
    public virtual string GenusName => "Thermophis";

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
