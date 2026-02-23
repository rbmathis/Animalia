using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Euleptes;

/// <summary>
/// Abstract class for Euleptes (genus).
/// NCBI TaxId: 460620
/// </summary>
public abstract class Euleptes : Sphaerodactylidae, IEuleptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euleptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460620;

    /// <inheritdoc />
    public virtual string GenusName => "Euleptes";

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
