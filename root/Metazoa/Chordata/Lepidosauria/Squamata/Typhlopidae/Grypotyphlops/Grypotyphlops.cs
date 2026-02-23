using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Grypotyphlops;

/// <summary>
/// Abstract class for Grypotyphlops (genus).
/// NCBI TaxId: 1544895
/// </summary>
public abstract class Grypotyphlops : Typhlopidae, IGrypotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grypotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544895;

    /// <inheritdoc />
    public virtual string GenusName => "Grypotyphlops";

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
