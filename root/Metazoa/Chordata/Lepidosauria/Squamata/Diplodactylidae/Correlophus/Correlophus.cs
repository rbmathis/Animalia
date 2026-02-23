using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Correlophus;

/// <summary>
/// Abstract class for Correlophus (genus).
/// NCBI TaxId: 1479064
/// </summary>
public abstract class Correlophus : Diplodactylidae, ICorrelophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Correlophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1479064;

    /// <inheritdoc />
    public virtual string GenusName => "Correlophus";

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
