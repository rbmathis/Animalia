using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Yunnanilus;

/// <summary>
/// Abstract class for Yunnanilus (genus).
/// NCBI TaxId: 241470
/// </summary>
public abstract class Yunnanilus : Nemacheilidae, IYunnanilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yunnanilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241470;

    /// <inheritdoc />
    public virtual string GenusName => "Yunnanilus";

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
