using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Heterandria;

/// <summary>
/// Abstract class for Heterandria (genus).
/// NCBI TaxId: 55103
/// </summary>
public abstract class Heterandria : Poeciliidae, IHeterandria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterandria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55103;

    /// <inheritdoc />
    public virtual string GenusName => "Heterandria";

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
