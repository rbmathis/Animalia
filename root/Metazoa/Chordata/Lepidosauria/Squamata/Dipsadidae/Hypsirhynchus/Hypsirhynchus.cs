using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Hypsirhynchus;

/// <summary>
/// Abstract class for Hypsirhynchus (genus).
/// NCBI TaxId: 121337
/// </summary>
public abstract class Hypsirhynchus : Dipsadidae, IHypsirhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsirhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121337;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsirhynchus";

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
