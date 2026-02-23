using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Asaccus;

/// <summary>
/// Abstract class for Asaccus (genus).
/// NCBI TaxId: 502507
/// </summary>
public abstract class Asaccus : Phyllodactylidae, IAsaccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asaccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 502507;

    /// <inheritdoc />
    public virtual string GenusName => "Asaccus";

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
