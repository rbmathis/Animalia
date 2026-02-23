using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhopilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhopilidae.Gerrhopilus;

/// <summary>
/// Abstract class for Gerrhopilus (genus).
/// NCBI TaxId: 1278934
/// </summary>
public abstract class Gerrhopilus : Gerrhopilidae, IGerrhopilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gerrhopilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1278934;

    /// <inheritdoc />
    public virtual string GenusName => "Gerrhopilus";

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
