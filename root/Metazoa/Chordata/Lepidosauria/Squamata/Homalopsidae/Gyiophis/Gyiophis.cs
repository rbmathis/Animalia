using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Gyiophis;

/// <summary>
/// Abstract class for Gyiophis (genus).
/// NCBI TaxId: 2012480
/// </summary>
public abstract class Gyiophis : Homalopsidae, IGyiophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gyiophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2012480;

    /// <inheritdoc />
    public virtual string GenusName => "Gyiophis";

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
