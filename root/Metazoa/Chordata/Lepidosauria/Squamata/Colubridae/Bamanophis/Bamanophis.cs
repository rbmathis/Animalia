using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Bamanophis;

/// <summary>
/// Abstract class for Bamanophis (genus).
/// NCBI TaxId: 1392241
/// </summary>
public abstract class Bamanophis : Colubridae, IBamanophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bamanophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1392241;

    /// <inheritdoc />
    public virtual string GenusName => "Bamanophis";

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
