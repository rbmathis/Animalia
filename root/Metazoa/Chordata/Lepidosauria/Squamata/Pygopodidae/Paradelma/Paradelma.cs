using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae.Paradelma;

/// <summary>
/// Abstract class for Paradelma (genus).
/// NCBI TaxId: 592669
/// </summary>
public abstract class Paradelma : Pygopodidae, IParadelma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradelma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 592669;

    /// <inheritdoc />
    public virtual string GenusName => "Paradelma";

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
