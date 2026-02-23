using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Neophema;

/// <summary>
/// Abstract class for Neophema (genus).
/// NCBI TaxId: 35536
/// </summary>
public abstract class Neophema : Psittacidae, INeophema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neophema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 35536;

    /// <inheritdoc />
    public virtual string GenusName => "Neophema";

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
