using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Pseudorasbora;

/// <summary>
/// Abstract class for Pseudorasbora (genus).
/// NCBI TaxId: 38758
/// </summary>
public abstract class Pseudorasbora : Gobionidae, IPseudorasbora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudorasbora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38758;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudorasbora";

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
