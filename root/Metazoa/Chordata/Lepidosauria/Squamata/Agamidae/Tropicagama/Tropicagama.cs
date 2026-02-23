using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Tropicagama;

/// <summary>
/// Abstract class for Tropicagama (genus).
/// NCBI TaxId: 2849038
/// </summary>
public abstract class Tropicagama : Agamidae, ITropicagama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropicagama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2849038;

    /// <inheritdoc />
    public virtual string GenusName => "Tropicagama";

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
