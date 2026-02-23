using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Cemophora;

/// <summary>
/// Abstract class for Cemophora (genus).
/// NCBI TaxId: 94896
/// </summary>
public abstract class Cemophora : Colubridae, ICemophora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cemophora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94896;

    /// <inheritdoc />
    public virtual string GenusName => "Cemophora";

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
