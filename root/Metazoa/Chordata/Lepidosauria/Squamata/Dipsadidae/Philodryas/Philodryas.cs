using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Philodryas;

/// <summary>
/// Abstract class for Philodryas (genus).
/// NCBI TaxId: 120304
/// </summary>
public abstract class Philodryas : Dipsadidae, IPhilodryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philodryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 120304;

    /// <inheritdoc />
    public virtual string GenusName => "Philodryas";

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
