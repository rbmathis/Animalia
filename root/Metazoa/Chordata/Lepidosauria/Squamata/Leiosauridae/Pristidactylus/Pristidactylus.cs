using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Pristidactylus;

/// <summary>
/// Abstract class for Pristidactylus (genus).
/// NCBI TaxId: 43614
/// </summary>
public abstract class Pristidactylus : Leiosauridae, IPristidactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristidactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43614;

    /// <inheritdoc />
    public virtual string GenusName => "Pristidactylus";

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
