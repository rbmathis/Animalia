using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Sicyases;

/// <summary>
/// Abstract class for Sicyases (genus).
/// NCBI TaxId: 741944
/// </summary>
public abstract class Sicyases : Gobiesocidae, ISicyases
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sicyases";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 741944;

    /// <inheritdoc />
    public virtual string GenusName => "Sicyases";

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
