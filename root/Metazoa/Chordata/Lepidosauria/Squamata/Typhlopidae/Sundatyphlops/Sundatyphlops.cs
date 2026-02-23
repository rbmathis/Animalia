using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Sundatyphlops;

/// <summary>
/// Abstract class for Sundatyphlops (genus).
/// NCBI TaxId: 2022834
/// </summary>
public abstract class Sundatyphlops : Typhlopidae, ISundatyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sundatyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2022834;

    /// <inheritdoc />
    public virtual string GenusName => "Sundatyphlops";

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
