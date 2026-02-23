using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Anisolepis;

/// <summary>
/// Abstract class for Anisolepis (genus).
/// NCBI TaxId: 161141
/// </summary>
public abstract class Anisolepis : Leiosauridae, IAnisolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anisolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161141;

    /// <inheritdoc />
    public virtual string GenusName => "Anisolepis";

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
