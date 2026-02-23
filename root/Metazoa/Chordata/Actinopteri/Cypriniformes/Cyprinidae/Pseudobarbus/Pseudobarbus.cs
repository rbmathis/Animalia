using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Pseudobarbus;

/// <summary>
/// Abstract class for Pseudobarbus (genus).
/// NCBI TaxId: 100124
/// </summary>
public abstract class Pseudobarbus : Cyprinidae, IPseudobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100124;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobarbus";

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
