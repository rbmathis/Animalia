using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Stenodus;

/// <summary>
/// Abstract class for Stenodus (genus).
/// NCBI TaxId: 59295
/// </summary>
public abstract class Stenodus : Salmonidae, IStenodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stenodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59295;

    /// <inheritdoc />
    public virtual string GenusName => "Stenodus";

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
