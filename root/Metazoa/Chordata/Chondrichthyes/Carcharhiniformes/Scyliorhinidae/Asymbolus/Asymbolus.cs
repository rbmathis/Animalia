using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Asymbolus;

/// <summary>
/// Abstract class for Asymbolus (genus).
/// NCBI TaxId: 263700
/// </summary>
public abstract class Asymbolus : Scyliorhinidae, IAsymbolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asymbolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 263700;

    /// <inheritdoc />
    public virtual string GenusName => "Asymbolus";

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
