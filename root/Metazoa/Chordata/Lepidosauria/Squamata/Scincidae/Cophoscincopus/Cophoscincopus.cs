using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Cophoscincopus;

/// <summary>
/// Abstract class for Cophoscincopus (genus).
/// NCBI TaxId: 1544369
/// </summary>
public abstract class Cophoscincopus : Scincidae, ICophoscincopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cophoscincopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544369;

    /// <inheritdoc />
    public virtual string GenusName => "Cophoscincopus";

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
