using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Imantodes;

/// <summary>
/// Abstract class for Imantodes (genus).
/// NCBI TaxId: 121342
/// </summary>
public abstract class Imantodes : Dipsadidae, IImantodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Imantodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121342;

    /// <inheritdoc />
    public virtual string GenusName => "Imantodes";

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
