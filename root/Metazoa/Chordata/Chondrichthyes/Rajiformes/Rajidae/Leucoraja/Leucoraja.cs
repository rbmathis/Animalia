using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Leucoraja;

/// <summary>
/// Abstract class for Leucoraja (genus).
/// NCBI TaxId: 117861
/// </summary>
public abstract class Leucoraja : Rajidae, ILeucoraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucoraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117861;

    /// <inheritdoc />
    public virtual string GenusName => "Leucoraja";

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
