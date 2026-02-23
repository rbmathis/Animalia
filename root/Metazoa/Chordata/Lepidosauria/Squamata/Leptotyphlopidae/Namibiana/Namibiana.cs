using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Namibiana;

/// <summary>
/// Abstract class for Namibiana (genus).
/// NCBI TaxId: 711324
/// </summary>
public abstract class Namibiana : Leptotyphlopidae, INamibiana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Namibiana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 711324;

    /// <inheritdoc />
    public virtual string GenusName => "Namibiana";

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
