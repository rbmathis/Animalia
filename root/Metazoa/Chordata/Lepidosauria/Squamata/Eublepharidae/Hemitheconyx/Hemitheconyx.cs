using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae.Hemitheconyx;

/// <summary>
/// Abstract class for Hemitheconyx (genus).
/// NCBI TaxId: 96740
/// </summary>
public abstract class Hemitheconyx : Eublepharidae, IHemitheconyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemitheconyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96740;

    /// <inheritdoc />
    public virtual string GenusName => "Hemitheconyx";

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
