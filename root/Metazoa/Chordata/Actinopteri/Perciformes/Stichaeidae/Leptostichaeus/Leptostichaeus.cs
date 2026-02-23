using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Leptostichaeus;

/// <summary>
/// Abstract class for Leptostichaeus (genus).
/// NCBI TaxId: 1138468
/// </summary>
public abstract class Leptostichaeus : Stichaeidae, ILeptostichaeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptostichaeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1138468;

    /// <inheritdoc />
    public virtual string GenusName => "Leptostichaeus";

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
