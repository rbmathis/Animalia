using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Cyclodomorphus;

/// <summary>
/// Abstract class for Cyclodomorphus (genus).
/// NCBI TaxId: 161943
/// </summary>
public abstract class Cyclodomorphus : Scincidae, ICyclodomorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclodomorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161943;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclodomorphus";

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
