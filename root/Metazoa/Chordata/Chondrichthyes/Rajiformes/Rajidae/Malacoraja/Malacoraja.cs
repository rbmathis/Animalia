using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Malacoraja;

/// <summary>
/// Abstract class for Malacoraja (genus).
/// NCBI TaxId: 117862
/// </summary>
public abstract class Malacoraja : Rajidae, IMalacoraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacoraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117862;

    /// <inheritdoc />
    public virtual string GenusName => "Malacoraja";

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
