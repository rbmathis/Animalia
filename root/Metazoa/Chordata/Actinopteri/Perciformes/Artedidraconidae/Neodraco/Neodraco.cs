using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae.Neodraco;

/// <summary>
/// Abstract class for Neodraco (genus).
/// NCBI TaxId: 2994820
/// </summary>
public abstract class Neodraco : Artedidraconidae, INeodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2994820;

    /// <inheritdoc />
    public virtual string GenusName => "Neodraco";

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
