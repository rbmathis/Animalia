using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Trachylepis;

/// <summary>
/// Abstract class for Trachylepis (genus).
/// NCBI TaxId: 323737
/// </summary>
public abstract class Trachylepis : Scincidae, ITrachylepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachylepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 323737;

    /// <inheritdoc />
    public virtual string GenusName => "Trachylepis";

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
