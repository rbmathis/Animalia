using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Blanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Blanidae.Blanus;

/// <summary>
/// Abstract class for Blanus (genus).
/// NCBI TaxId: 227090
/// </summary>
public abstract class Blanus : Blanidae, IBlanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227090;

    /// <inheritdoc />
    public virtual string GenusName => "Blanus";

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
