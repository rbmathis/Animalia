using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae.Desmodema;

/// <summary>
/// Abstract class for Desmodema (genus).
/// NCBI TaxId: 320417
/// </summary>
public abstract class Desmodema : Trachipteridae, IDesmodema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Desmodema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320417;

    /// <inheritdoc />
    public virtual string GenusName => "Desmodema";

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
