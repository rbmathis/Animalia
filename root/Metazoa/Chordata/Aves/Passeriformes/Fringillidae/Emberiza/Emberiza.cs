using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Emberiza;

/// <summary>
/// Abstract class for Emberiza (genus).
/// NCBI TaxId: 30424
/// </summary>
public abstract class Emberiza : Fringillidae, IEmberiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emberiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30424;

    /// <inheritdoc />
    public virtual string GenusName => "Emberiza";

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
