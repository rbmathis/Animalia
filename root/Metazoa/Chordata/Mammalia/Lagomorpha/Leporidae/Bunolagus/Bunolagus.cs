using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Bunolagus;

/// <summary>
/// Abstract class for Bunolagus (genus).
/// NCBI TaxId: 48084
/// </summary>
public abstract class Bunolagus : Leporidae, IBunolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bunolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48084;

    /// <inheritdoc />
    public virtual string GenusName => "Bunolagus";

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
