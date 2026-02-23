using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Pseudopoecilia;

/// <summary>
/// Abstract class for Pseudopoecilia (genus).
/// NCBI TaxId: 417471
/// </summary>
public abstract class Pseudopoecilia : Poeciliidae, IPseudopoecilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudopoecilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 417471;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudopoecilia";

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
