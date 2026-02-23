using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Psilorhamphus;

/// <summary>
/// Abstract class for Psilorhamphus (genus).
/// NCBI TaxId: 519475
/// </summary>
public abstract class Psilorhamphus : Rhinocryptidae, IPsilorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psilorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 519475;

    /// <inheritdoc />
    public virtual string GenusName => "Psilorhamphus";

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
