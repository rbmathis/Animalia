using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Kolekanos;

/// <summary>
/// Abstract class for Kolekanos (genus).
/// NCBI TaxId: 1534312
/// </summary>
public abstract class Kolekanos : Gekkonidae, IKolekanos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kolekanos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1534312;

    /// <inheritdoc />
    public virtual string GenusName => "Kolekanos";

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
