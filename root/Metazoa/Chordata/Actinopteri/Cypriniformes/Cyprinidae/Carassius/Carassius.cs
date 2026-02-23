using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassius;

/// <summary>
/// Abstract class for Carassius (genus).
/// NCBI TaxId: 7956
/// </summary>
public abstract class Carassius : Cyprinidae, ICarassius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carassius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7956;

    /// <inheritdoc />
    public virtual string GenusName => "Carassius";

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
