using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Aetomylaeus;

/// <summary>
/// Abstract class for Aetomylaeus (genus).
/// NCBI TaxId: 115856
/// </summary>
public abstract class Aetomylaeus : Myliobatidae, IAetomylaeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aetomylaeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115856;

    /// <inheritdoc />
    public virtual string GenusName => "Aetomylaeus";

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
