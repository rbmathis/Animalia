using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Gongylomorphus;

/// <summary>
/// Abstract class for Gongylomorphus (genus).
/// NCBI TaxId: 161947
/// </summary>
public abstract class Gongylomorphus : Scincidae, IGongylomorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gongylomorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161947;

    /// <inheritdoc />
    public virtual string GenusName => "Gongylomorphus";

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
