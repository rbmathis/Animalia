using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Rhamdia;

/// <summary>
/// Abstract class for Rhamdia (genus).
/// NCBI TaxId: 55672
/// </summary>
public abstract class Rhamdia : Pimelodidae, IRhamdia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamdia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55672;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamdia";

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
