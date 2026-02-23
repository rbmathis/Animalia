using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Agonopsis;

/// <summary>
/// Abstract class for Agonopsis (genus).
/// NCBI TaxId: 428026
/// </summary>
public abstract class Agonopsis : Agonidae, IAgonopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agonopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428026;

    /// <inheritdoc />
    public virtual string GenusName => "Agonopsis";

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
