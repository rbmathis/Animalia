using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Amerotyphlops;

/// <summary>
/// Abstract class for Amerotyphlops (genus).
/// NCBI TaxId: 1539293
/// </summary>
public abstract class Amerotyphlops : Typhlopidae, IAmerotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amerotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1539293;

    /// <inheritdoc />
    public virtual string GenusName => "Amerotyphlops";

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
