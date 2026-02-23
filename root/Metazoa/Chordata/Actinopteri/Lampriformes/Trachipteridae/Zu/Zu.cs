using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae.Zu;

/// <summary>
/// Abstract class for Zu (genus).
/// NCBI TaxId: 143324
/// </summary>
public abstract class Zu : Trachipteridae, IZu
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zu";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143324;

    /// <inheritdoc />
    public virtual string GenusName => "Zu";

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
