using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Stichaeopsis;

/// <summary>
/// Abstract class for Stichaeopsis (genus).
/// NCBI TaxId: 1049577
/// </summary>
public abstract class Stichaeopsis : Stichaeidae, IStichaeopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stichaeopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1049577;

    /// <inheritdoc />
    public virtual string GenusName => "Stichaeopsis";

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
