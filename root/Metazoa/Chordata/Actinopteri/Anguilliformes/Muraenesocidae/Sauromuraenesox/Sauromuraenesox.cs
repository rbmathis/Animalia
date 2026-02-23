using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae.Sauromuraenesox;

/// <summary>
/// Abstract class for Sauromuraenesox (genus).
/// NCBI TaxId: 2923227
/// </summary>
public abstract class Sauromuraenesox : Muraenesocidae, ISauromuraenesox
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sauromuraenesox";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2923227;

    /// <inheritdoc />
    public virtual string GenusName => "Sauromuraenesox";

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
