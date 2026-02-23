using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Kentropyx;

/// <summary>
/// Abstract class for Kentropyx (genus).
/// NCBI TaxId: 96442
/// </summary>
public abstract class Kentropyx : Teiidae, IKentropyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kentropyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96442;

    /// <inheritdoc />
    public virtual string GenusName => "Kentropyx";

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
