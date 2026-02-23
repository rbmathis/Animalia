using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cossyphicula;

/// <summary>
/// Abstract class for Cossyphicula (genus).
/// NCBI TaxId: 228333
/// </summary>
public abstract class Cossyphicula : Muscicapidae, ICossyphicula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cossyphicula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228333;

    /// <inheritdoc />
    public virtual string GenusName => "Cossyphicula";

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
