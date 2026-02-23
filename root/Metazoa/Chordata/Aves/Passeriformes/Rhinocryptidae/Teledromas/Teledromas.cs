using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Teledromas;

/// <summary>
/// Abstract class for Teledromas (genus).
/// NCBI TaxId: 589990
/// </summary>
public abstract class Teledromas : Rhinocryptidae, ITeledromas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Teledromas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589990;

    /// <inheritdoc />
    public virtual string GenusName => "Teledromas";

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
