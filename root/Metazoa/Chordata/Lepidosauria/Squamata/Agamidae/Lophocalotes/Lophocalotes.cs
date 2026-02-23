using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Lophocalotes;

/// <summary>
/// Abstract class for Lophocalotes (genus).
/// NCBI TaxId: 1545019
/// </summary>
public abstract class Lophocalotes : Agamidae, ILophocalotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophocalotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545019;

    /// <inheritdoc />
    public virtual string GenusName => "Lophocalotes";

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
