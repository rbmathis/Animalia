using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Enhydris;

/// <summary>
/// Abstract class for Enhydris (genus).
/// NCBI TaxId: 39145
/// </summary>
public abstract class Enhydris : Homalopsidae, IEnhydris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enhydris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39145;

    /// <inheritdoc />
    public virtual string GenusName => "Enhydris";

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
