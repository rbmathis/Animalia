using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Scytalopus;

/// <summary>
/// Abstract class for Scytalopus (genus).
/// NCBI TaxId: 9168
/// </summary>
public abstract class Scytalopus : Rhinocryptidae, IScytalopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scytalopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9168;

    /// <inheritdoc />
    public virtual string GenusName => "Scytalopus";

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
