using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Phimophis;

/// <summary>
/// Abstract class for Phimophis (genus).
/// NCBI TaxId: 666104
/// </summary>
public abstract class Phimophis : Dipsadidae, IPhimophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phimophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666104;

    /// <inheritdoc />
    public virtual string GenusName => "Phimophis";

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
