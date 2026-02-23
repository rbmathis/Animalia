using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Lophognathus;

/// <summary>
/// Abstract class for Lophognathus (genus).
/// NCBI TaxId: 103704
/// </summary>
public abstract class Lophognathus : Agamidae, ILophognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103704;

    /// <inheritdoc />
    public virtual string GenusName => "Lophognathus";

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
