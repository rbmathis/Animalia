using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Madagascarophis;

/// <summary>
/// Abstract class for Madagascarophis (genus).
/// NCBI TaxId: 46312
/// </summary>
public abstract class Madagascarophis : Lamprophiidae, IMadagascarophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Madagascarophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46312;

    /// <inheritdoc />
    public virtual string GenusName => "Madagascarophis";

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
