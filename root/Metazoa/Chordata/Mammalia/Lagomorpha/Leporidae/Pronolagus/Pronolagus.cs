using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Pronolagus;

/// <summary>
/// Abstract class for Pronolagus (genus).
/// NCBI TaxId: 42058
/// </summary>
public abstract class Pronolagus : Leporidae, IPronolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pronolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42058;

    /// <inheritdoc />
    public virtual string GenusName => "Pronolagus";

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
