using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Pseudobalistes;

/// <summary>
/// Abstract class for Pseudobalistes (genus).
/// NCBI TaxId: 303694
/// </summary>
public abstract class Pseudobalistes : Balistidae, IPseudobalistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobalistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303694;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobalistes";

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
