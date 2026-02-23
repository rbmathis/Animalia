using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Myioparus;

/// <summary>
/// Abstract class for Myioparus (genus).
/// NCBI TaxId: 758460
/// </summary>
public abstract class Myioparus : Muscicapidae, IMyioparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myioparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 758460;

    /// <inheritdoc />
    public virtual string GenusName => "Myioparus";

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
