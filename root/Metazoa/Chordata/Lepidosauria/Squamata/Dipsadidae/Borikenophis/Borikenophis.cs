using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Borikenophis;

/// <summary>
/// Abstract class for Borikenophis (genus).
/// NCBI TaxId: 1260275
/// </summary>
public abstract class Borikenophis : Dipsadidae, IBorikenophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Borikenophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1260275;

    /// <inheritdoc />
    public virtual string GenusName => "Borikenophis";

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
