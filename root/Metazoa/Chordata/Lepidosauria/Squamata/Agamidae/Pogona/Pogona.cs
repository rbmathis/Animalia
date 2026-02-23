using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Pogona;

/// <summary>
/// Abstract class for Pogona (genus).
/// NCBI TaxId: 52201
/// </summary>
public abstract class Pogona : Agamidae, IPogona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pogona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52201;

    /// <inheritdoc />
    public virtual string GenusName => "Pogona";

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
