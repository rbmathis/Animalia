using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Scapanus;

/// <summary>
/// Abstract class for Scapanus (genus).
/// NCBI TaxId: 182672
/// </summary>
public abstract class Scapanus : Talpidae, IScapanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scapanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182672;

    /// <inheritdoc />
    public virtual string GenusName => "Scapanus";

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
