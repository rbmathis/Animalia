using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Eos;

/// <summary>
/// Abstract class for Eos (genus).
/// NCBI TaxId: 176063
/// </summary>
public abstract class Eos : Psittaculidae, IEos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176063;

    /// <inheritdoc />
    public virtual string GenusName => "Eos";

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
