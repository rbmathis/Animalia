using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae.Lialis;

/// <summary>
/// Abstract class for Lialis (genus).
/// NCBI TaxId: 52171
/// </summary>
public abstract class Lialis : Pygopodidae, ILialis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lialis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52171;

    /// <inheritdoc />
    public virtual string GenusName => "Lialis";

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
