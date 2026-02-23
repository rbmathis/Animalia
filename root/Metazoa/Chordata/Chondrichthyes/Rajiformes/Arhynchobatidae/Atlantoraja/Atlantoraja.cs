using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Atlantoraja;

/// <summary>
/// Abstract class for Atlantoraja (genus).
/// NCBI TaxId: 117868
/// </summary>
public abstract class Atlantoraja : Arhynchobatidae, IAtlantoraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atlantoraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117868;

    /// <inheritdoc />
    public virtual string GenusName => "Atlantoraja";

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
