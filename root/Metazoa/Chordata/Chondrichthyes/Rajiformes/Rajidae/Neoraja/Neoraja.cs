using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Neoraja;

/// <summary>
/// Abstract class for Neoraja (genus).
/// NCBI TaxId: 117863
/// </summary>
public abstract class Neoraja : Rajidae, INeoraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117863;

    /// <inheritdoc />
    public virtual string GenusName => "Neoraja";

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
