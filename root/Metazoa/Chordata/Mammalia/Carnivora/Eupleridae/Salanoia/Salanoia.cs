using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Salanoia;

/// <summary>
/// Abstract class for Salanoia (genus).
/// NCBI TaxId: 219104
/// </summary>
public abstract class Salanoia : Eupleridae, ISalanoia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salanoia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 219104;

    /// <inheritdoc />
    public virtual string GenusName => "Salanoia";

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
