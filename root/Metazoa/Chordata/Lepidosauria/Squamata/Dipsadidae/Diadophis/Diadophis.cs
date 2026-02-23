using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Diadophis;

/// <summary>
/// Abstract class for Diadophis (genus).
/// NCBI TaxId: 158806
/// </summary>
public abstract class Diadophis : Dipsadidae, IDiadophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diadophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158806;

    /// <inheritdoc />
    public virtual string GenusName => "Diadophis";

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
