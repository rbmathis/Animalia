using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Ferania;

/// <summary>
/// Abstract class for Ferania (genus).
/// NCBI TaxId: 1544587
/// </summary>
public abstract class Ferania : Homalopsidae, IFerania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ferania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544587;

    /// <inheritdoc />
    public virtual string GenusName => "Ferania";

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
