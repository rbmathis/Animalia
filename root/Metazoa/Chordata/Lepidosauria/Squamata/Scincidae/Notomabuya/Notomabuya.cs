using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Notomabuya;

/// <summary>
/// Abstract class for Notomabuya (genus).
/// NCBI TaxId: 1332249
/// </summary>
public abstract class Notomabuya : Scincidae, INotomabuya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notomabuya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1332249;

    /// <inheritdoc />
    public virtual string GenusName => "Notomabuya";

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
