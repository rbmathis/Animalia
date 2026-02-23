using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae.Histiodraco;

/// <summary>
/// Abstract class for Histiodraco (genus).
/// NCBI TaxId: 36207
/// </summary>
public abstract class Histiodraco : Artedidraconidae, IHistiodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Histiodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36207;

    /// <inheritdoc />
    public virtual string GenusName => "Histiodraco";

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
