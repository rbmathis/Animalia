using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Caaeteboia;

/// <summary>
/// Abstract class for Caaeteboia (genus).
/// NCBI TaxId: 1260278
/// </summary>
public abstract class Caaeteboia : Dipsadidae, ICaaeteboia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caaeteboia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1260278;

    /// <inheritdoc />
    public virtual string GenusName => "Caaeteboia";

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
