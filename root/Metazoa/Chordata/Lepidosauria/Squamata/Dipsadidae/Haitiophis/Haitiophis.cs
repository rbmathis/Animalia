using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Haitiophis;

/// <summary>
/// Abstract class for Haitiophis (genus).
/// NCBI TaxId: 1335310
/// </summary>
public abstract class Haitiophis : Dipsadidae, IHaitiophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haitiophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1335310;

    /// <inheritdoc />
    public virtual string GenusName => "Haitiophis";

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
