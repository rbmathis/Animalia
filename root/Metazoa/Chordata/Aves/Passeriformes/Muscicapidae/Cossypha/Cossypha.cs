using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cossypha;

/// <summary>
/// Abstract class for Cossypha (genus).
/// NCBI TaxId: 228313
/// </summary>
public abstract class Cossypha : Muscicapidae, ICossypha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cossypha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228313;

    /// <inheritdoc />
    public virtual string GenusName => "Cossypha";

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
