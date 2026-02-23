using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Virginia;

/// <summary>
/// Abstract class for Virginia (genus).
/// NCBI TaxId: 183605
/// </summary>
public abstract class Virginia : Colubridae, IVirginia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Virginia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183605;

    /// <inheritdoc />
    public virtual string GenusName => "Virginia";

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
