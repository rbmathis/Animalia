using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae.Delma;

/// <summary>
/// Abstract class for Delma (genus).
/// NCBI TaxId: 71024
/// </summary>
public abstract class Delma : Pygopodidae, IDelma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Delma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71024;

    /// <inheritdoc />
    public virtual string GenusName => "Delma";

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
