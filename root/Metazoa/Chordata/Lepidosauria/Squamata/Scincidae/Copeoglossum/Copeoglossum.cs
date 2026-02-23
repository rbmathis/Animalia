using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Copeoglossum;

/// <summary>
/// Abstract class for Copeoglossum (genus).
/// NCBI TaxId: 1070447
/// </summary>
public abstract class Copeoglossum : Scincidae, ICopeoglossum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Copeoglossum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1070447;

    /// <inheritdoc />
    public virtual string GenusName => "Copeoglossum";

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
