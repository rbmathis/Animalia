using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Psomophis;

/// <summary>
/// Abstract class for Psomophis (genus).
/// NCBI TaxId: 666110
/// </summary>
public abstract class Psomophis : Dipsadidae, IPsomophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psomophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666110;

    /// <inheritdoc />
    public virtual string GenusName => "Psomophis";

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
