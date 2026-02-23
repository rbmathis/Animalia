using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Plesiopuntius;

/// <summary>
/// Abstract class for Plesiopuntius (genus).
/// NCBI TaxId: 3080743
/// </summary>
public abstract class Plesiopuntius : Cyprinidae, IPlesiopuntius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plesiopuntius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3080743;

    /// <inheritdoc />
    public virtual string GenusName => "Plesiopuntius";

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
