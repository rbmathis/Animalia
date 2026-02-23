using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Hapalopsittaca;

/// <summary>
/// Abstract class for Hapalopsittaca (genus).
/// NCBI TaxId: 303327
/// </summary>
public abstract class Hapalopsittaca : Psittacidae, IHapalopsittaca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hapalopsittaca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303327;

    /// <inheritdoc />
    public virtual string GenusName => "Hapalopsittaca";

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
