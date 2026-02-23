using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Eleoscytalopus;

/// <summary>
/// Abstract class for Eleoscytalopus (genus).
/// NCBI TaxId: 573004
/// </summary>
public abstract class Eleoscytalopus : Rhinocryptidae, IEleoscytalopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eleoscytalopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 573004;

    /// <inheritdoc />
    public virtual string GenusName => "Eleoscytalopus";

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
