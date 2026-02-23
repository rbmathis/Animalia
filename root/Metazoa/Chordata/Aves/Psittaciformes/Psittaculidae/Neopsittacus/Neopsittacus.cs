using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Neopsittacus;

/// <summary>
/// Abstract class for Neopsittacus (genus).
/// NCBI TaxId: 176067
/// </summary>
public abstract class Neopsittacus : Psittaculidae, INeopsittacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neopsittacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176067;

    /// <inheritdoc />
    public virtual string GenusName => "Neopsittacus";

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
