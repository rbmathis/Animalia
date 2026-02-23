using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Scaptochirus;

/// <summary>
/// Abstract class for Scaptochirus (genus).
/// NCBI TaxId: 446352
/// </summary>
public abstract class Scaptochirus : Talpidae, IScaptochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaptochirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446352;

    /// <inheritdoc />
    public virtual string GenusName => "Scaptochirus";

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
