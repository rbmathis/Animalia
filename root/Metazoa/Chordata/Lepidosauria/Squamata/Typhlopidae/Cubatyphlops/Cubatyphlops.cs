using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Cubatyphlops;

/// <summary>
/// Abstract class for Cubatyphlops (genus).
/// NCBI TaxId: 1494026
/// </summary>
public abstract class Cubatyphlops : Typhlopidae, ICubatyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cubatyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1494026;

    /// <inheritdoc />
    public virtual string GenusName => "Cubatyphlops";

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
