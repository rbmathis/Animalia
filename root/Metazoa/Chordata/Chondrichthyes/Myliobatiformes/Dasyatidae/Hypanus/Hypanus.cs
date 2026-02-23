using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Hypanus;

/// <summary>
/// Abstract class for Hypanus (genus).
/// NCBI TaxId: 2055258
/// </summary>
public abstract class Hypanus : Dasyatidae, IHypanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2055258;

    /// <inheritdoc />
    public virtual string GenusName => "Hypanus";

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
