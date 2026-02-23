using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Lithobates;

/// <summary>
/// Abstract class for Lithobates (genus).
/// NCBI TaxId: 192752
/// </summary>
public abstract class Lithobates : Ranidae, ILithobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lithobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192752;

    /// <inheritdoc />
    public virtual string GenusName => "Lithobates";

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
