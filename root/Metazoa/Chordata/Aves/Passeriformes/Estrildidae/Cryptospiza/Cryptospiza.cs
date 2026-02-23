using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Cryptospiza;

/// <summary>
/// Abstract class for Cryptospiza (genus).
/// NCBI TaxId: 221967
/// </summary>
public abstract class Cryptospiza : Estrildidae, ICryptospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221967;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptospiza";

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
