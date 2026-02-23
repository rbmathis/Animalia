using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Macrocalamus;

/// <summary>
/// Abstract class for Macrocalamus (genus).
/// NCBI TaxId: 1545025
/// </summary>
public abstract class Macrocalamus : Colubridae, IMacrocalamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrocalamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545025;

    /// <inheritdoc />
    public virtual string GenusName => "Macrocalamus";

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
