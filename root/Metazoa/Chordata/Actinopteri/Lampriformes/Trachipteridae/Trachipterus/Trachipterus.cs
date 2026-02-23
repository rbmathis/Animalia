using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae.Trachipterus;

/// <summary>
/// Abstract class for Trachipterus (genus).
/// NCBI TaxId: 81394
/// </summary>
public abstract class Trachipterus : Trachipteridae, ITrachipterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachipterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81394;

    /// <inheritdoc />
    public virtual string GenusName => "Trachipterus";

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
