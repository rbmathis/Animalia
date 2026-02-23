using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Malayopython;

/// <summary>
/// Abstract class for Malayopython (genus).
/// NCBI TaxId: 1496304
/// </summary>
public abstract class Malayopython : Pythonidae, IMalayopython
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malayopython";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1496304;

    /// <inheritdoc />
    public virtual string GenusName => "Malayopython";

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
