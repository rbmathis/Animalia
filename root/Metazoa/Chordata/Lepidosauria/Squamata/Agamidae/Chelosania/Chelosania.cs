using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Chelosania;

/// <summary>
/// Abstract class for Chelosania (genus).
/// NCBI TaxId: 118198
/// </summary>
public abstract class Chelosania : Agamidae, IChelosania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelosania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118198;

    /// <inheritdoc />
    public virtual string GenusName => "Chelosania";

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
