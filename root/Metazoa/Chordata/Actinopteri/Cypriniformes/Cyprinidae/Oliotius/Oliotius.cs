using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Oliotius;

/// <summary>
/// Abstract class for Oliotius (genus).
/// NCBI TaxId: 1606675
/// </summary>
public abstract class Oliotius : Cyprinidae, IOliotius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oliotius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1606675;

    /// <inheritdoc />
    public virtual string GenusName => "Oliotius";

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
