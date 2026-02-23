using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Gomesophis;

/// <summary>
/// Abstract class for Gomesophis (genus).
/// NCBI TaxId: 666082
/// </summary>
public abstract class Gomesophis : Dipsadidae, IGomesophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gomesophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666082;

    /// <inheritdoc />
    public virtual string GenusName => "Gomesophis";

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
