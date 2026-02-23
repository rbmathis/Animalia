using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Cerberus;

/// <summary>
/// Abstract class for Cerberus (genus).
/// NCBI TaxId: 46266
/// </summary>
public abstract class Cerberus : Homalopsidae, ICerberus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cerberus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46266;

    /// <inheritdoc />
    public virtual string GenusName => "Cerberus";

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
