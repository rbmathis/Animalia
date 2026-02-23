using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Glaphyromorphus;

/// <summary>
/// Abstract class for Glaphyromorphus (genus).
/// NCBI TaxId: 220781
/// </summary>
public abstract class Glaphyromorphus : Scincidae, IGlaphyromorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaphyromorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 220781;

    /// <inheritdoc />
    public virtual string GenusName => "Glaphyromorphus";

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
