using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Stichaeus;

/// <summary>
/// Abstract class for Stichaeus (genus).
/// NCBI TaxId: 291110
/// </summary>
public abstract class Stichaeus : Stichaeidae, IStichaeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stichaeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 291110;

    /// <inheritdoc />
    public virtual string GenusName => "Stichaeus";

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
