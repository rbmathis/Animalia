using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherinason;

/// <summary>
/// Abstract class for Atherinason (genus).
/// NCBI TaxId: 669295
/// </summary>
public abstract class Atherinason : Atherinidae, IAtherinason
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atherinason";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 669295;

    /// <inheritdoc />
    public virtual string GenusName => "Atherinason";

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
