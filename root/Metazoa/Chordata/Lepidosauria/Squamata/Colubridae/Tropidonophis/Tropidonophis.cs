using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Tropidonophis;

/// <summary>
/// Abstract class for Tropidonophis (genus).
/// NCBI TaxId: 1458434
/// </summary>
public abstract class Tropidonophis : Colubridae, ITropidonophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropidonophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1458434;

    /// <inheritdoc />
    public virtual string GenusName => "Tropidonophis";

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
