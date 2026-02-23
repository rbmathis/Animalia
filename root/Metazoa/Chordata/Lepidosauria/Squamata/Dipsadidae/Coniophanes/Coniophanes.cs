using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Coniophanes;

/// <summary>
/// Abstract class for Coniophanes (genus).
/// NCBI TaxId: 427712
/// </summary>
public abstract class Coniophanes : Dipsadidae, IConiophanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coniophanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 427712;

    /// <inheritdoc />
    public virtual string GenusName => "Coniophanes";

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
