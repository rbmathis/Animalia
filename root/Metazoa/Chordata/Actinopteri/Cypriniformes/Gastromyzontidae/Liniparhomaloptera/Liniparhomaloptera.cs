using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Liniparhomaloptera;

/// <summary>
/// Abstract class for Liniparhomaloptera (genus).
/// NCBI TaxId: 241463
/// </summary>
public abstract class Liniparhomaloptera : Gastromyzontidae, ILiniparhomaloptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liniparhomaloptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241463;

    /// <inheritdoc />
    public virtual string GenusName => "Liniparhomaloptera";

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
