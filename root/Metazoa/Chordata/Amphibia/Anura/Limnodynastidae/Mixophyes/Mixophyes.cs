using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Mixophyes;

/// <summary>
/// Abstract class for Mixophyes (genus).
/// NCBI TaxId: 260895
/// </summary>
public abstract class Mixophyes : Limnodynastidae, IMixophyes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mixophyes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 260895;

    /// <inheritdoc />
    public virtual string GenusName => "Mixophyes";

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
