using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Urocotyledon;

/// <summary>
/// Abstract class for Urocotyledon (genus).
/// NCBI TaxId: 707138
/// </summary>
public abstract class Urocotyledon : Gekkonidae, IUrocotyledon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urocotyledon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 707138;

    /// <inheritdoc />
    public virtual string GenusName => "Urocotyledon";

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
