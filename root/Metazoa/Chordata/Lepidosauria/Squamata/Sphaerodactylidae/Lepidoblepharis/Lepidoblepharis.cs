using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Lepidoblepharis;

/// <summary>
/// Abstract class for Lepidoblepharis (genus).
/// NCBI TaxId: 71157
/// </summary>
public abstract class Lepidoblepharis : Sphaerodactylidae, ILepidoblepharis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidoblepharis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71157;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidoblepharis";

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
