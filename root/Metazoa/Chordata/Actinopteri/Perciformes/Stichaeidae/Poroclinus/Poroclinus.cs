using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Poroclinus;

/// <summary>
/// Abstract class for Poroclinus (genus).
/// NCBI TaxId: 557413
/// </summary>
public abstract class Poroclinus : Stichaeidae, IPoroclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poroclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 557413;

    /// <inheritdoc />
    public virtual string GenusName => "Poroclinus";

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
