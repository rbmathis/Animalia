using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Caulophrynidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Caulophrynidae.Caulophryne;

/// <summary>
/// Abstract class for Caulophryne (genus).
/// NCBI TaxId: 181421
/// </summary>
public abstract class Caulophryne : Caulophrynidae, ICaulophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caulophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181421;

    /// <inheritdoc />
    public virtual string GenusName => "Caulophryne";

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
