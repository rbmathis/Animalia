using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Chiroxiphia;

/// <summary>
/// Abstract class for Chiroxiphia (genus).
/// NCBI TaxId: 196026
/// </summary>
public abstract class Chiroxiphia : Pipridae, IChiroxiphia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chiroxiphia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196026;

    /// <inheritdoc />
    public virtual string GenusName => "Chiroxiphia";

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
