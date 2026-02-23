using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Persiophis;

/// <summary>
/// Abstract class for Persiophis (genus).
/// NCBI TaxId: 2761957
/// </summary>
public abstract class Persiophis : Colubridae, IPersiophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Persiophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2761957;

    /// <inheritdoc />
    public virtual string GenusName => "Persiophis";

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
