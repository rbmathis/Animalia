using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Muraenolepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Muraenolepididae.Muraenolepis;

/// <summary>
/// Abstract class for Muraenolepis (genus).
/// NCBI TaxId: 487676
/// </summary>
public abstract class Muraenolepis : Muraenolepididae, IMuraenolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muraenolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 487676;

    /// <inheritdoc />
    public virtual string GenusName => "Muraenolepis";

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
