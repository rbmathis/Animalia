using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Chioninia;

/// <summary>
/// Abstract class for Chioninia (genus).
/// NCBI TaxId: 889814
/// </summary>
public abstract class Chioninia : Scincidae, IChioninia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chioninia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 889814;

    /// <inheritdoc />
    public virtual string GenusName => "Chioninia";

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
