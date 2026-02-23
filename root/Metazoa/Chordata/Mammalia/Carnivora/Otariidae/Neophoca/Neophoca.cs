using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Neophoca;

/// <summary>
/// Abstract class for Neophoca (genus).
/// NCBI TaxId: 161929
/// </summary>
public abstract class Neophoca : Otariidae, INeophoca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neophoca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161929;

    /// <inheritdoc />
    public virtual string GenusName => "Neophoca";

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
