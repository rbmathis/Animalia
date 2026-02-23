using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Pavoraja;

/// <summary>
/// Abstract class for Pavoraja (genus).
/// NCBI TaxId: 117873
/// </summary>
public abstract class Pavoraja : Arhynchobatidae, IPavoraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pavoraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117873;

    /// <inheritdoc />
    public virtual string GenusName => "Pavoraja";

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
