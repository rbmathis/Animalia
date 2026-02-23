using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Sylvilagus;

/// <summary>
/// Abstract class for Sylvilagus (genus).
/// NCBI TaxId: 9987
/// </summary>
public abstract class Sylvilagus : Leporidae, ISylvilagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sylvilagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9987;

    /// <inheritdoc />
    public virtual string GenusName => "Sylvilagus";

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
