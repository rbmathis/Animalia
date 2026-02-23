using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Oxyrhopus;

/// <summary>
/// Abstract class for Oxyrhopus (genus).
/// NCBI TaxId: 120301
/// </summary>
public abstract class Oxyrhopus : Dipsadidae, IOxyrhopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyrhopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 120301;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyrhopus";

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
