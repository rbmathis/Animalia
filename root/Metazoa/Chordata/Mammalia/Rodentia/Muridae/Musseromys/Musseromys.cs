using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Musseromys;

/// <summary>
/// Abstract class for Musseromys (genus).
/// NCBI TaxId: 2219201
/// </summary>
public abstract class Musseromys : Muridae, IMusseromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Musseromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2219201;

    /// <inheritdoc />
    public virtual string GenusName => "Musseromys";

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
