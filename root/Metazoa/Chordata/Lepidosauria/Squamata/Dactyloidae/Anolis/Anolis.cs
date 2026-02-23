using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Abstract class for Anolis (genus).
/// NCBI TaxId: 28376
/// </summary>
public abstract class Anolis : Dactyloidae, IAnolis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anolis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28376;

    /// <inheritdoc />
    public virtual string GenusName => "Anolis";

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
