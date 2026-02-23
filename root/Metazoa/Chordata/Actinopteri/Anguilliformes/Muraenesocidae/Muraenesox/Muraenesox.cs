using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae.Muraenesox;

/// <summary>
/// Abstract class for Muraenesox (genus).
/// NCBI TaxId: 7945
/// </summary>
public abstract class Muraenesox : Muraenesocidae, IMuraenesox
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muraenesox";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7945;

    /// <inheritdoc />
    public virtual string GenusName => "Muraenesox";

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
