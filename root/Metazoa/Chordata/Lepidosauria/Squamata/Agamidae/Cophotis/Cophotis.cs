using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Cophotis;

/// <summary>
/// Abstract class for Cophotis (genus).
/// NCBI TaxId: 118201
/// </summary>
public abstract class Cophotis : Agamidae, ICophotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cophotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118201;

    /// <inheritdoc />
    public virtual string GenusName => "Cophotis";

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
