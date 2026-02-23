using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Oreopsittacus;

/// <summary>
/// Abstract class for Oreopsittacus (genus).
/// NCBI TaxId: 176069
/// </summary>
public abstract class Oreopsittacus : Psittaculidae, IOreopsittacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreopsittacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176069;

    /// <inheritdoc />
    public virtual string GenusName => "Oreopsittacus";

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
