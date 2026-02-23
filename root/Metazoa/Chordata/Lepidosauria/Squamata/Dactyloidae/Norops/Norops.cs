using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Norops;

/// <summary>
/// Abstract class for Norops (genus).
/// NCBI TaxId: 2591386
/// </summary>
public abstract class Norops : Dactyloidae, INorops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Norops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2591386;

    /// <inheritdoc />
    public virtual string GenusName => "Norops";

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
