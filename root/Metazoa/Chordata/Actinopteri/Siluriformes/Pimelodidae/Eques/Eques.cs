using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Eques;

/// <summary>
/// Abstract class for Eques (genus).
/// NCBI TaxId: 3363410
/// </summary>
public abstract class Eques : Pimelodidae, IEques
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eques";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363410;

    /// <inheritdoc />
    public virtual string GenusName => "Eques";

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
