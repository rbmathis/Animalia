using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Hoplocephalus;

/// <summary>
/// Abstract class for Hoplocephalus (genus).
/// NCBI TaxId: 83402
/// </summary>
public abstract class Hoplocephalus : Elapidae, IHoplocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83402;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplocephalus";

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
