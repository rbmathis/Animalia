using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aplocheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aplocheilidae.Pachypanchax;

/// <summary>
/// Abstract class for Pachypanchax (genus).
/// NCBI TaxId: 52662
/// </summary>
public abstract class Pachypanchax : Aplocheilidae, IPachypanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachypanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52662;

    /// <inheritdoc />
    public virtual string GenusName => "Pachypanchax";

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
