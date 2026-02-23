using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Diopsittaca;

/// <summary>
/// Abstract class for Diopsittaca (genus).
/// NCBI TaxId: 178887
/// </summary>
public abstract class Diopsittaca : Psittacidae, IDiopsittaca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diopsittaca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 178887;

    /// <inheritdoc />
    public virtual string GenusName => "Diopsittaca";

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
