using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Xenopholis;

/// <summary>
/// Abstract class for Xenopholis (genus).
/// NCBI TaxId: 699600
/// </summary>
public abstract class Xenopholis : Dipsadidae, IXenopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699600;

    /// <inheritdoc />
    public virtual string GenusName => "Xenopholis";

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
