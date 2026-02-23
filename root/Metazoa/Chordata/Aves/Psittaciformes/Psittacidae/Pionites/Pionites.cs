using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pionites;

/// <summary>
/// Abstract class for Pionites (genus).
/// NCBI TaxId: 309865
/// </summary>
public abstract class Pionites : Psittacidae, IPionites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pionites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 309865;

    /// <inheritdoc />
    public virtual string GenusName => "Pionites";

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
