using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Cantoria;

/// <summary>
/// Abstract class for Cantoria (genus).
/// NCBI TaxId: 192585
/// </summary>
public abstract class Cantoria : Homalopsidae, ICantoria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cantoria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192585;

    /// <inheritdoc />
    public virtual string GenusName => "Cantoria";

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
