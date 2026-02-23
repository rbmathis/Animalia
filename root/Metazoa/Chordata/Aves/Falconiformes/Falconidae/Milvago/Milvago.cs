using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Milvago;

/// <summary>
/// Abstract class for Milvago (genus).
/// NCBI TaxId: 56336
/// </summary>
public abstract class Milvago : Falconidae, IMilvago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Milvago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56336;

    /// <inheritdoc />
    public virtual string GenusName => "Milvago";

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
