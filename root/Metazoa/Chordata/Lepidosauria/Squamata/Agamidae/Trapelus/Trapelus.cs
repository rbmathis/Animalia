using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Trapelus;

/// <summary>
/// Abstract class for Trapelus (genus).
/// NCBI TaxId: 52209
/// </summary>
public abstract class Trapelus : Agamidae, ITrapelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trapelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52209;

    /// <inheritdoc />
    public virtual string GenusName => "Trapelus";

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
