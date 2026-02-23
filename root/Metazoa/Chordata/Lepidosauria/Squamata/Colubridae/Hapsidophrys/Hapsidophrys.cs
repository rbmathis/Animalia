using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Hapsidophrys;

/// <summary>
/// Abstract class for Hapsidophrys (genus).
/// NCBI TaxId: 211646
/// </summary>
public abstract class Hapsidophrys : Colubridae, IHapsidophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hapsidophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 211646;

    /// <inheritdoc />
    public virtual string GenusName => "Hapsidophrys";

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
