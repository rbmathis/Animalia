using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Arctoraja;

/// <summary>
/// Abstract class for Arctoraja (genus).
/// NCBI TaxId: 3363387
/// </summary>
public abstract class Arctoraja : Arhynchobatidae, IArctoraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arctoraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363387;

    /// <inheritdoc />
    public virtual string GenusName => "Arctoraja";

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
