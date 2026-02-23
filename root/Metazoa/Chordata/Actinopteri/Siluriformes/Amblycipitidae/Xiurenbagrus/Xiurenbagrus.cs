using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae.Xiurenbagrus;

/// <summary>
/// Abstract class for Xiurenbagrus (genus).
/// NCBI TaxId: 349547
/// </summary>
public abstract class Xiurenbagrus : Amblycipitidae, IXiurenbagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xiurenbagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349547;

    /// <inheritdoc />
    public virtual string GenusName => "Xiurenbagrus";

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
