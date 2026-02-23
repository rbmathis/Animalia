using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Xenagama;

/// <summary>
/// Abstract class for Xenagama (genus).
/// NCBI TaxId: 236746
/// </summary>
public abstract class Xenagama : Agamidae, IXenagama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenagama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 236746;

    /// <inheritdoc />
    public virtual string GenusName => "Xenagama";

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
