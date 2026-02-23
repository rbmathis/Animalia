using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Brachyseps;

/// <summary>
/// Abstract class for Brachyseps (genus).
/// NCBI TaxId: 2200832
/// </summary>
public abstract class Brachyseps : Scincidae, IBrachyseps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyseps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2200832;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyseps";

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
