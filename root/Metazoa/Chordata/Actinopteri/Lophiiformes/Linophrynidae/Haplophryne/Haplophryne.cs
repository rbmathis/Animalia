using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae.Haplophryne;

/// <summary>
/// Abstract class for Haplophryne (genus).
/// NCBI TaxId: 412652
/// </summary>
public abstract class Haplophryne : Linophrynidae, IHaplophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haplophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412652;

    /// <inheritdoc />
    public virtual string GenusName => "Haplophryne";

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
