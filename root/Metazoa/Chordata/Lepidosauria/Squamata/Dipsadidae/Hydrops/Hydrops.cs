using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Hydrops;

/// <summary>
/// Abstract class for Hydrops (genus).
/// NCBI TaxId: 121335
/// </summary>
public abstract class Hydrops : Dipsadidae, IHydrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121335;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrops";

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
