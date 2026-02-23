using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Kanakysaurus;

/// <summary>
/// Abstract class for Kanakysaurus (genus).
/// NCBI TaxId: 394182
/// </summary>
public abstract class Kanakysaurus : Scincidae, IKanakysaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kanakysaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 394182;

    /// <inheritdoc />
    public virtual string GenusName => "Kanakysaurus";

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
