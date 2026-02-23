using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Leptoclinus;

/// <summary>
/// Abstract class for Leptoclinus (genus).
/// NCBI TaxId: 980416
/// </summary>
public abstract class Leptoclinus : Stichaeidae, ILeptoclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptoclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 980416;

    /// <inheritdoc />
    public virtual string GenusName => "Leptoclinus";

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
