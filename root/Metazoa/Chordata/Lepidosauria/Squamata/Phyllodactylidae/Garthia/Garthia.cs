using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Garthia;

/// <summary>
/// Abstract class for Garthia (genus).
/// NCBI TaxId: 1542676
/// </summary>
public abstract class Garthia : Phyllodactylidae, IGarthia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Garthia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1542676;

    /// <inheritdoc />
    public virtual string GenusName => "Garthia";

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
