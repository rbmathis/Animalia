using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Neoheterandria;

/// <summary>
/// Abstract class for Neoheterandria (genus).
/// NCBI TaxId: 188088
/// </summary>
public abstract class Neoheterandria : Poeciliidae, INeoheterandria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoheterandria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188088;

    /// <inheritdoc />
    public virtual string GenusName => "Neoheterandria";

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
