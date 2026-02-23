using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Euroscaptor;

/// <summary>
/// Abstract class for Euroscaptor (genus).
/// NCBI TaxId: 114410
/// </summary>
public abstract class Euroscaptor : Talpidae, IEuroscaptor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euroscaptor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114410;

    /// <inheritdoc />
    public virtual string GenusName => "Euroscaptor";

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
