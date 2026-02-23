using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Manacus;

/// <summary>
/// Abstract class for Manacus (genus).
/// NCBI TaxId: 196036
/// </summary>
public abstract class Manacus : Pipridae, IManacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Manacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196036;

    /// <inheritdoc />
    public virtual string GenusName => "Manacus";

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
