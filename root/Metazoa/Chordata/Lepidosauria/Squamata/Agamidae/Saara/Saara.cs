using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Saara;

/// <summary>
/// Abstract class for Saara (genus).
/// NCBI TaxId: 668967
/// </summary>
public abstract class Saara : Agamidae, ISaara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 668967;

    /// <inheritdoc />
    public virtual string GenusName => "Saara";

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
