using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Micropoecilia;

/// <summary>
/// Abstract class for Micropoecilia (genus).
/// NCBI TaxId: 648186
/// </summary>
public abstract class Micropoecilia : Poeciliidae, IMicropoecilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micropoecilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648186;

    /// <inheritdoc />
    public virtual string GenusName => "Micropoecilia";

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
