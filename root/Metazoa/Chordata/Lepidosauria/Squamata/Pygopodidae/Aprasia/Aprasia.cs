using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae.Aprasia;

/// <summary>
/// Abstract class for Aprasia (genus).
/// NCBI TaxId: 207560
/// </summary>
public abstract class Aprasia : Pygopodidae, IAprasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aprasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 207560;

    /// <inheritdoc />
    public virtual string GenusName => "Aprasia";

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
