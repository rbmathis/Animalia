using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Aetobatus;

/// <summary>
/// Abstract class for Aetobatus (genus).
/// NCBI TaxId: 87139
/// </summary>
public abstract class Aetobatus : Myliobatidae, IAetobatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aetobatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 87139;

    /// <inheritdoc />
    public virtual string GenusName => "Aetobatus";

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
