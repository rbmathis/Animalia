using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Hypsiglena;

/// <summary>
/// Abstract class for Hypsiglena (genus).
/// NCBI TaxId: 46304
/// </summary>
public abstract class Hypsiglena : Dipsadidae, IHypsiglena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsiglena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46304;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsiglena";

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
