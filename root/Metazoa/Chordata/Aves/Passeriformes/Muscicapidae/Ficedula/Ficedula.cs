using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Ficedula;

/// <summary>
/// Abstract class for Ficedula (genus).
/// NCBI TaxId: 36292
/// </summary>
public abstract class Ficedula : Muscicapidae, IFicedula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ficedula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36292;

    /// <inheritdoc />
    public virtual string GenusName => "Ficedula";

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
