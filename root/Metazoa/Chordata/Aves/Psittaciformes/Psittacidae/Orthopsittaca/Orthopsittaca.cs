using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Orthopsittaca;

/// <summary>
/// Abstract class for Orthopsittaca (genus).
/// NCBI TaxId: 178889
/// </summary>
public abstract class Orthopsittaca : Psittacidae, IOrthopsittaca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthopsittaca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 178889;

    /// <inheritdoc />
    public virtual string GenusName => "Orthopsittaca";

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
