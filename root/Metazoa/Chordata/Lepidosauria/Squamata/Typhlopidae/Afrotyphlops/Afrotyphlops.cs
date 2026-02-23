using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Afrotyphlops;

/// <summary>
/// Abstract class for Afrotyphlops (genus).
/// NCBI TaxId: 760000
/// </summary>
public abstract class Afrotyphlops : Typhlopidae, IAfrotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Afrotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 760000;

    /// <inheritdoc />
    public virtual string GenusName => "Afrotyphlops";

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
