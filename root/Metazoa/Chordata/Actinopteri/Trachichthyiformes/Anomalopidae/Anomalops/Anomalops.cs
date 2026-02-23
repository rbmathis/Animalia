using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae.Anomalops;

/// <summary>
/// Abstract class for Anomalops (genus).
/// NCBI TaxId: 181432
/// </summary>
public abstract class Anomalops : Anomalopidae, IAnomalops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anomalops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181432;

    /// <inheritdoc />
    public virtual string GenusName => "Anomalops";

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
