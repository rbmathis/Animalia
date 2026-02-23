using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Halophryne;

/// <summary>
/// Abstract class for Halophryne (genus).
/// NCBI TaxId: 990940
/// </summary>
public abstract class Halophryne : Batrachoididae, IHalophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990940;

    /// <inheritdoc />
    public virtual string GenusName => "Halophryne";

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
