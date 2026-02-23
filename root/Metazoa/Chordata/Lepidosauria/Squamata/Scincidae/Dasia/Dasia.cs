using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Dasia;

/// <summary>
/// Abstract class for Dasia (genus).
/// NCBI TaxId: 96734
/// </summary>
public abstract class Dasia : Scincidae, IDasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96734;

    /// <inheritdoc />
    public virtual string GenusName => "Dasia";

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
