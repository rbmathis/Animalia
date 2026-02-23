using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Lagonosticta;

/// <summary>
/// Abstract class for Lagonosticta (genus).
/// NCBI TaxId: 187434
/// </summary>
public abstract class Lagonosticta : Estrildidae, ILagonosticta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagonosticta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187434;

    /// <inheritdoc />
    public virtual string GenusName => "Lagonosticta";

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
