using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Oreoscaptor;

/// <summary>
/// Abstract class for Oreoscaptor (genus).
/// NCBI TaxId: 2835216
/// </summary>
public abstract class Oreoscaptor : Talpidae, IOreoscaptor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreoscaptor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2835216;

    /// <inheritdoc />
    public virtual string GenusName => "Oreoscaptor";

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
