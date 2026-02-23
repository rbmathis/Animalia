using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Chuanchia;

/// <summary>
/// Abstract class for Chuanchia (genus).
/// NCBI TaxId: 279400
/// </summary>
public abstract class Chuanchia : Cyprinidae, IChuanchia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chuanchia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 279400;

    /// <inheritdoc />
    public virtual string GenusName => "Chuanchia";

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
