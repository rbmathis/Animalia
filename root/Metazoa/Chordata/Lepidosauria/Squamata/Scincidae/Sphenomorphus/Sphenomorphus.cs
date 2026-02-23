using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sphenomorphus;

/// <summary>
/// Abstract class for Sphenomorphus (genus).
/// NCBI TaxId: 71018
/// </summary>
public abstract class Sphenomorphus : Scincidae, ISphenomorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphenomorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71018;

    /// <inheritdoc />
    public virtual string GenusName => "Sphenomorphus";

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
