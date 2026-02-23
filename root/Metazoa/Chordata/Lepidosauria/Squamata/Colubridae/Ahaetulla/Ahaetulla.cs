using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Ahaetulla;

/// <summary>
/// Abstract class for Ahaetulla (genus).
/// NCBI TaxId: 186572
/// </summary>
public abstract class Ahaetulla : Colubridae, IAhaetulla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ahaetulla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186572;

    /// <inheritdoc />
    public virtual string GenusName => "Ahaetulla";

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
