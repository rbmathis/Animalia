using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Sewellia;

/// <summary>
/// Abstract class for Sewellia (genus).
/// NCBI TaxId: 516037
/// </summary>
public abstract class Sewellia : Gastromyzontidae, ISewellia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sewellia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 516037;

    /// <inheritdoc />
    public virtual string GenusName => "Sewellia";

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
