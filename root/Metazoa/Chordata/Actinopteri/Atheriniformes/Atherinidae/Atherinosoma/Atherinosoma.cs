using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherinosoma;

/// <summary>
/// Abstract class for Atherinosoma (genus).
/// NCBI TaxId: 69131
/// </summary>
public abstract class Atherinosoma : Atherinidae, IAtherinosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atherinosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69131;

    /// <inheritdoc />
    public virtual string GenusName => "Atherinosoma";

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
