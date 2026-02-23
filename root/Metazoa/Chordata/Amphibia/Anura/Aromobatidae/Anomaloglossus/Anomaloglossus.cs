using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Anomaloglossus;

/// <summary>
/// Abstract class for Anomaloglossus (genus).
/// NCBI TaxId: 479886
/// </summary>
public abstract class Anomaloglossus : Aromobatidae, IAnomaloglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anomaloglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 479886;

    /// <inheritdoc />
    public virtual string GenusName => "Anomaloglossus";

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
