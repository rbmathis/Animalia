using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Rostroraja;

/// <summary>
/// Abstract class for Rostroraja (genus).
/// NCBI TaxId: 117866
/// </summary>
public abstract class Rostroraja : Rajidae, IRostroraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rostroraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117866;

    /// <inheritdoc />
    public virtual string GenusName => "Rostroraja";

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
