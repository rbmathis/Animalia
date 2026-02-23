using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Nannopsittaca;

/// <summary>
/// Abstract class for Nannopsittaca (genus).
/// NCBI TaxId: 429467
/// </summary>
public abstract class Nannopsittaca : Psittacidae, INannopsittaca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannopsittaca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 429467;

    /// <inheritdoc />
    public virtual string GenusName => "Nannopsittaca";

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
