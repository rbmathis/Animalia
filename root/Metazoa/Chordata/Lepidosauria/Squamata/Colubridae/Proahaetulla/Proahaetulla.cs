using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Proahaetulla;

/// <summary>
/// Abstract class for Proahaetulla (genus).
/// NCBI TaxId: 2597820
/// </summary>
public abstract class Proahaetulla : Colubridae, IProahaetulla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proahaetulla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2597820;

    /// <inheritdoc />
    public virtual string GenusName => "Proahaetulla";

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
