using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Elapomorphus;

/// <summary>
/// Abstract class for Elapomorphus (genus).
/// NCBI TaxId: 666080
/// </summary>
public abstract class Elapomorphus : Dipsadidae, IElapomorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elapomorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666080;

    /// <inheritdoc />
    public virtual string GenusName => "Elapomorphus";

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
