using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae.Linophryne;

/// <summary>
/// Abstract class for Linophryne (genus).
/// NCBI TaxId: 242965
/// </summary>
public abstract class Linophryne : Linophrynidae, ILinophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Linophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242965;

    /// <inheritdoc />
    public virtual string GenusName => "Linophryne";

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
