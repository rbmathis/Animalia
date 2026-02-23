using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Notophthalmus;

/// <summary>
/// Abstract class for Notophthalmus (genus).
/// NCBI TaxId: 8315
/// </summary>
public abstract class Notophthalmus : Salamandridae, INotophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8315;

    /// <inheritdoc />
    public virtual string GenusName => "Notophthalmus";

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
