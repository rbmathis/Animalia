using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Ichnotropis;

/// <summary>
/// Abstract class for Ichnotropis (genus).
/// NCBI TaxId: 80447
/// </summary>
public abstract class Ichnotropis : Lacertidae, IIchnotropis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichnotropis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80447;

    /// <inheritdoc />
    public virtual string GenusName => "Ichnotropis";

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
