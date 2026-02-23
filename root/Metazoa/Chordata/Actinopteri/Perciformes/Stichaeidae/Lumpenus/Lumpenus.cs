using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Lumpenus;

/// <summary>
/// Abstract class for Lumpenus (genus).
/// NCBI TaxId: 428035
/// </summary>
public abstract class Lumpenus : Stichaeidae, ILumpenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lumpenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428035;

    /// <inheritdoc />
    public virtual string GenusName => "Lumpenus";

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
