using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Trachischium;

/// <summary>
/// Abstract class for Trachischium (genus).
/// NCBI TaxId: 1165737
/// </summary>
public abstract class Trachischium : Colubridae, ITrachischium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachischium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1165737;

    /// <inheritdoc />
    public virtual string GenusName => "Trachischium";

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
