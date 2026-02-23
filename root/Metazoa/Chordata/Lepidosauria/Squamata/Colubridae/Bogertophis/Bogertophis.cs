using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Bogertophis;

/// <summary>
/// Abstract class for Bogertophis (genus).
/// NCBI TaxId: 94894
/// </summary>
public abstract class Bogertophis : Colubridae, IBogertophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bogertophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94894;

    /// <inheritdoc />
    public virtual string GenusName => "Bogertophis";

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
