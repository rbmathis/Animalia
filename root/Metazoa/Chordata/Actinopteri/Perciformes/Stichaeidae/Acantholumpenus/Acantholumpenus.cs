using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Acantholumpenus;

/// <summary>
/// Abstract class for Acantholumpenus (genus).
/// NCBI TaxId: 1049574
/// </summary>
public abstract class Acantholumpenus : Stichaeidae, IAcantholumpenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acantholumpenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1049574;

    /// <inheritdoc />
    public virtual string GenusName => "Acantholumpenus";

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
