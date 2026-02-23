using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Fordonia;

/// <summary>
/// Abstract class for Fordonia (genus).
/// NCBI TaxId: 192594
/// </summary>
public abstract class Fordonia : Homalopsidae, IFordonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fordonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192594;

    /// <inheritdoc />
    public virtual string GenusName => "Fordonia";

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
