using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Egernia;

/// <summary>
/// Abstract class for Egernia (genus).
/// NCBI TaxId: 71014
/// </summary>
public abstract class Egernia : Scincidae, IEgernia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Egernia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71014;

    /// <inheritdoc />
    public virtual string GenusName => "Egernia";

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
