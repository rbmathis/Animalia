using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Platystomatichthys;

/// <summary>
/// Abstract class for Platystomatichthys (genus).
/// NCBI TaxId: 1150242
/// </summary>
public abstract class Platystomatichthys : Pimelodidae, IPlatystomatichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platystomatichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1150242;

    /// <inheritdoc />
    public virtual string GenusName => "Platystomatichthys";

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
