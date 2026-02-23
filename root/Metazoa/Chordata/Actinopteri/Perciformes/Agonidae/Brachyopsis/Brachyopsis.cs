using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Brachyopsis;

/// <summary>
/// Abstract class for Brachyopsis (genus).
/// NCBI TaxId: 412976
/// </summary>
public abstract class Brachyopsis : Agonidae, IBrachyopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412976;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyopsis";

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
