using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Breviraja;

/// <summary>
/// Abstract class for Breviraja (genus).
/// NCBI TaxId: 117855
/// </summary>
public abstract class Breviraja : Rajidae, IBreviraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Breviraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117855;

    /// <inheritdoc />
    public virtual string GenusName => "Breviraja";

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
