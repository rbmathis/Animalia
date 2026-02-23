using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae.Pogonophryne;

/// <summary>
/// Abstract class for Pogonophryne (genus).
/// NCBI TaxId: 36209
/// </summary>
public abstract class Pogonophryne : Artedidraconidae, IPogonophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pogonophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36209;

    /// <inheritdoc />
    public virtual string GenusName => "Pogonophryne";

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
