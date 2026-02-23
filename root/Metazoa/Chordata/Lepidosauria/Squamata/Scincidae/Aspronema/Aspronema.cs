using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Aspronema;

/// <summary>
/// Abstract class for Aspronema (genus).
/// NCBI TaxId: 1331795
/// </summary>
public abstract class Aspronema : Scincidae, IAspronema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspronema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1331795;

    /// <inheritdoc />
    public virtual string GenusName => "Aspronema";

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
