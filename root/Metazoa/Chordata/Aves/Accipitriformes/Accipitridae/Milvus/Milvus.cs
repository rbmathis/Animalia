using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Milvus;

/// <summary>
/// Abstract class for Milvus (genus).
/// NCBI TaxId: 43517
/// </summary>
public abstract class Milvus : Accipitridae, IMilvus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Milvus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43517;

    /// <inheritdoc />
    public virtual string GenusName => "Milvus";

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
