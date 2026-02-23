using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Hypoptophis;

/// <summary>
/// Abstract class for Hypoptophis (genus).
/// NCBI TaxId: 1544995
/// </summary>
public abstract class Hypoptophis : Lamprophiidae, IHypoptophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypoptophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544995;

    /// <inheritdoc />
    public virtual string GenusName => "Hypoptophis";

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
