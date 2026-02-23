using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Chamaetylas;

/// <summary>
/// Abstract class for Chamaetylas (genus).
/// NCBI TaxId: 1743359
/// </summary>
public abstract class Chamaetylas : Muscicapidae, IChamaetylas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chamaetylas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1743359;

    /// <inheritdoc />
    public virtual string GenusName => "Chamaetylas";

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
