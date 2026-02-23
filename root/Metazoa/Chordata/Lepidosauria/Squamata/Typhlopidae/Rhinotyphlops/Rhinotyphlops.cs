using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Rhinotyphlops;

/// <summary>
/// Abstract class for Rhinotyphlops (genus).
/// NCBI TaxId: 292852
/// </summary>
public abstract class Rhinotyphlops : Typhlopidae, IRhinotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292852;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinotyphlops";

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
