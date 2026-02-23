using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Melopsittacus;

/// <summary>
/// Abstract class for Melopsittacus (genus).
/// NCBI TaxId: 13145
/// </summary>
public abstract class Melopsittacus : Psittaculidae, IMelopsittacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melopsittacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13145;

    /// <inheritdoc />
    public virtual string GenusName => "Melopsittacus";

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
