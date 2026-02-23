using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Scaphesthes;

/// <summary>
/// Abstract class for Scaphesthes (genus).
/// NCBI TaxId: 3413470
/// </summary>
public abstract class Scaphesthes : Cyprinidae, IScaphesthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaphesthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3413470;

    /// <inheritdoc />
    public virtual string GenusName => "Scaphesthes";

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
