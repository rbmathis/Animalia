using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Hemitripterus;

/// <summary>
/// Abstract class for Hemitripterus (genus).
/// NCBI TaxId: 8093
/// </summary>
public abstract class Hemitripterus : Agonidae, IHemitripterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemitripterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8093;

    /// <inheritdoc />
    public virtual string GenusName => "Hemitripterus";

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
