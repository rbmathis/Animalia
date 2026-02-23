using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Nesolagus;

/// <summary>
/// Abstract class for Nesolagus (genus).
/// NCBI TaxId: 104113
/// </summary>
public abstract class Nesolagus : Leporidae, INesolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 104113;

    /// <inheritdoc />
    public virtual string GenusName => "Nesolagus";

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
