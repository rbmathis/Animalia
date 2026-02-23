using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Maculabatis;

/// <summary>
/// Abstract class for Maculabatis (genus).
/// NCBI TaxId: 1930107
/// </summary>
public abstract class Maculabatis : Dasyatidae, IMaculabatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Maculabatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1930107;

    /// <inheritdoc />
    public virtual string GenusName => "Maculabatis";

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
