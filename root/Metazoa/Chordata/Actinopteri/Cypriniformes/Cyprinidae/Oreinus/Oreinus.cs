using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Oreinus;

/// <summary>
/// Abstract class for Oreinus (genus).
/// NCBI TaxId: 1764115
/// </summary>
public abstract class Oreinus : Cyprinidae, IOreinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1764115;

    /// <inheritdoc />
    public virtual string GenusName => "Oreinus";

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
