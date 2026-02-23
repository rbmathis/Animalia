using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Coggeria;

/// <summary>
/// Abstract class for Coggeria (genus).
/// NCBI TaxId: 405197
/// </summary>
public abstract class Coggeria : Scincidae, ICoggeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coggeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 405197;

    /// <inheritdoc />
    public virtual string GenusName => "Coggeria";

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
