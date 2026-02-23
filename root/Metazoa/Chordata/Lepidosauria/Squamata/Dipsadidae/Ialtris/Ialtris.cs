using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Ialtris;

/// <summary>
/// Abstract class for Ialtris (genus).
/// NCBI TaxId: 121340
/// </summary>
public abstract class Ialtris : Dipsadidae, IIaltris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ialtris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121340;

    /// <inheritdoc />
    public virtual string GenusName => "Ialtris";

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
