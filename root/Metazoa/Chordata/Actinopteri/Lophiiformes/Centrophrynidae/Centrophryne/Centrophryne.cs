using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Centrophrynidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Centrophrynidae.Centrophryne;

/// <summary>
/// Abstract class for Centrophryne (genus).
/// NCBI TaxId: 412646
/// </summary>
public abstract class Centrophryne : Centrophrynidae, ICentrophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412646;

    /// <inheritdoc />
    public virtual string GenusName => "Centrophryne";

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
