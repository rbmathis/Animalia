using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Pseudorhodeus;

/// <summary>
/// Abstract class for Pseudorhodeus (genus).
/// NCBI TaxId: 3363469
/// </summary>
public abstract class Pseudorhodeus : Acheilognathidae, IPseudorhodeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudorhodeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363469;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudorhodeus";

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
