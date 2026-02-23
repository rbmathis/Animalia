using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Podarcis;

/// <summary>
/// Abstract class for Podarcis (genus).
/// NCBI TaxId: 42163
/// </summary>
public abstract class Podarcis : Lacertidae, IPodarcis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podarcis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42163;

    /// <inheritdoc />
    public virtual string GenusName => "Podarcis";

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
