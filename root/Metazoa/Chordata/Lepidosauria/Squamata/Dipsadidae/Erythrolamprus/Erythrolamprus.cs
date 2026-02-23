using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Erythrolamprus;

/// <summary>
/// Abstract class for Erythrolamprus (genus).
/// NCBI TaxId: 121327
/// </summary>
public abstract class Erythrolamprus : Dipsadidae, IErythrolamprus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythrolamprus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121327;

    /// <inheritdoc />
    public virtual string GenusName => "Erythrolamprus";

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
