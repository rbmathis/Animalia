using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Zonosaurus;

/// <summary>
/// Abstract class for Zonosaurus (genus).
/// NCBI TaxId: 143653
/// </summary>
public abstract class Zonosaurus : Gerrhosauridae, IZonosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zonosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143653;

    /// <inheritdoc />
    public virtual string GenusName => "Zonosaurus";

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
