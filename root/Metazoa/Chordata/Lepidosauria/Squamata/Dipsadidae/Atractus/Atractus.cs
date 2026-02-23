using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Atractus;

/// <summary>
/// Abstract class for Atractus (genus).
/// NCBI TaxId: 121316
/// </summary>
public abstract class Atractus : Dipsadidae, IAtractus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atractus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121316;

    /// <inheritdoc />
    public virtual string GenusName => "Atractus";

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
