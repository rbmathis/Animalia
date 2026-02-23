using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scincella;

/// <summary>
/// Abstract class for Scincella (genus).
/// NCBI TaxId: 155318
/// </summary>
public abstract class Scincella : Scincidae, IScincella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scincella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 155318;

    /// <inheritdoc />
    public virtual string GenusName => "Scincella";

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
