using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Hypsilurus;

/// <summary>
/// Abstract class for Hypsilurus (genus).
/// NCBI TaxId: 103702
/// </summary>
public abstract class Hypsilurus : Agamidae, IHypsilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsilurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103702;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsilurus";

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
