using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Limnophis;

/// <summary>
/// Abstract class for Limnophis (genus).
/// NCBI TaxId: 1545013
/// </summary>
public abstract class Limnophis : Colubridae, ILimnophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545013;

    /// <inheritdoc />
    public virtual string GenusName => "Limnophis";

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
