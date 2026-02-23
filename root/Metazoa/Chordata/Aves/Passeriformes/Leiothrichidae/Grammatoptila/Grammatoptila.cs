using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Grammatoptila;

/// <summary>
/// Abstract class for Grammatoptila (genus).
/// NCBI TaxId: 2183783
/// </summary>
public abstract class Grammatoptila : Leiothrichidae, IGrammatoptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammatoptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2183783;

    /// <inheritdoc />
    public virtual string GenusName => "Grammatoptila";

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
