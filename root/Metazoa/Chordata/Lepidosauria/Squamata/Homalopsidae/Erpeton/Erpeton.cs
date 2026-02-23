using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Erpeton;

/// <summary>
/// Abstract class for Erpeton (genus).
/// NCBI TaxId: 192592
/// </summary>
public abstract class Erpeton : Homalopsidae, IErpeton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erpeton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192592;

    /// <inheritdoc />
    public virtual string GenusName => "Erpeton";

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
