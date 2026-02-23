using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Plectobranchus;

/// <summary>
/// Abstract class for Plectobranchus (genus).
/// NCBI TaxId: 57848
/// </summary>
public abstract class Plectobranchus : Stichaeidae, IPlectobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57848;

    /// <inheritdoc />
    public virtual string GenusName => "Plectobranchus";

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
