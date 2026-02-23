using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Tachyeres;

/// <summary>
/// Abstract class for Tachyeres (genus).
/// NCBI TaxId: 75880
/// </summary>
public abstract class Tachyeres : Anatidae, ITachyeres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachyeres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75880;

    /// <inheritdoc />
    public virtual string GenusName => "Tachyeres";

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
