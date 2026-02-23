using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Salamandrina;

/// <summary>
/// Abstract class for Salamandrina (genus).
/// NCBI TaxId: 305978
/// </summary>
public abstract class Salamandrina : Salamandridae, ISalamandrina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salamandrina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 305978;

    /// <inheritdoc />
    public virtual string GenusName => "Salamandrina";

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
