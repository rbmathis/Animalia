using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Intellagama;

/// <summary>
/// Abstract class for Intellagama (genus).
/// NCBI TaxId: 1473573
/// </summary>
public abstract class Intellagama : Agamidae, IIntellagama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Intellagama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1473573;

    /// <inheritdoc />
    public virtual string GenusName => "Intellagama";

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
