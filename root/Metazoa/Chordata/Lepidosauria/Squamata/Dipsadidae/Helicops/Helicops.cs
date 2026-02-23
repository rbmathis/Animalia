using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Helicops;

/// <summary>
/// Abstract class for Helicops (genus).
/// NCBI TaxId: 46306
/// </summary>
public abstract class Helicops : Dipsadidae, IHelicops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helicops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46306;

    /// <inheritdoc />
    public virtual string GenusName => "Helicops";

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
