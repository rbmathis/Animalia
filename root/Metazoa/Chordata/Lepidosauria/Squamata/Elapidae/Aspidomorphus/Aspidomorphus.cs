using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Aspidomorphus;

/// <summary>
/// Abstract class for Aspidomorphus (genus).
/// NCBI TaxId: 66183
/// </summary>
public abstract class Aspidomorphus : Elapidae, IAspidomorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspidomorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66183;

    /// <inheritdoc />
    public virtual string GenusName => "Aspidomorphus";

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
