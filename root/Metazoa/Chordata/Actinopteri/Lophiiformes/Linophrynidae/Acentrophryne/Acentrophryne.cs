using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae.Acentrophryne;

/// <summary>
/// Abstract class for Acentrophryne (genus).
/// NCBI TaxId: 412650
/// </summary>
public abstract class Acentrophryne : Linophrynidae, IAcentrophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acentrophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412650;

    /// <inheritdoc />
    public virtual string GenusName => "Acentrophryne";

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
