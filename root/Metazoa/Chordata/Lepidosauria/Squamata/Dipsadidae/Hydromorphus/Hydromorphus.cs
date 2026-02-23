using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Hydromorphus;

/// <summary>
/// Abstract class for Hydromorphus (genus).
/// NCBI TaxId: 699582
/// </summary>
public abstract class Hydromorphus : Dipsadidae, IHydromorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydromorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699582;

    /// <inheritdoc />
    public virtual string GenusName => "Hydromorphus";

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
