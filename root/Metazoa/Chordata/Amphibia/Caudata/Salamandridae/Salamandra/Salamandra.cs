using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Salamandra;

/// <summary>
/// Abstract class for Salamandra (genus).
/// NCBI TaxId: 57569
/// </summary>
public abstract class Salamandra : Salamandridae, ISalamandra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salamandra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57569;

    /// <inheritdoc />
    public virtual string GenusName => "Salamandra";

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
