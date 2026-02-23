using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Scaphognathops;

/// <summary>
/// Abstract class for Scaphognathops (genus).
/// NCBI TaxId: 643458
/// </summary>
public abstract class Scaphognathops : Cyprinidae, IScaphognathops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaphognathops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643458;

    /// <inheritdoc />
    public virtual string GenusName => "Scaphognathops";

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
