using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Anomalochromis;

/// <summary>
/// Abstract class for Anomalochromis (genus).
/// NCBI TaxId: 219379
/// </summary>
public abstract class Anomalochromis : Cichlidae, IAnomalochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anomalochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 219379;

    /// <inheritdoc />
    public virtual string GenusName => "Anomalochromis";

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
