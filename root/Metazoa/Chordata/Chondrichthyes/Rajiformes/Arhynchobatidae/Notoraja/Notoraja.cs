using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Notoraja;

/// <summary>
/// Abstract class for Notoraja (genus).
/// NCBI TaxId: 117872
/// </summary>
public abstract class Notoraja : Arhynchobatidae, INotoraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notoraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117872;

    /// <inheritdoc />
    public virtual string GenusName => "Notoraja";

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
