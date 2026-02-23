using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Anomaluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Anomaluridae.Anomalurus;

/// <summary>
/// Abstract class for Anomalurus (genus).
/// NCBI TaxId: 101664
/// </summary>
public abstract class Anomalurus : Anomaluridae, IAnomalurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anomalurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101664;

    /// <inheritdoc />
    public virtual string GenusName => "Anomalurus";

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
