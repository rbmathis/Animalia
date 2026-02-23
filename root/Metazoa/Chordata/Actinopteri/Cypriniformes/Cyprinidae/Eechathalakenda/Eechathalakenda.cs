using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Eechathalakenda;

/// <summary>
/// Abstract class for Eechathalakenda (genus).
/// NCBI TaxId: 2775982
/// </summary>
public abstract class Eechathalakenda : Cyprinidae, IEechathalakenda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eechathalakenda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2775982;

    /// <inheritdoc />
    public virtual string GenusName => "Eechathalakenda";

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
