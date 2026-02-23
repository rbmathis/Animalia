using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Taeniophallus;

/// <summary>
/// Abstract class for Taeniophallus (genus).
/// NCBI TaxId: 121367
/// </summary>
public abstract class Taeniophallus : Dipsadidae, ITaeniophallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taeniophallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121367;

    /// <inheritdoc />
    public virtual string GenusName => "Taeniophallus";

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
