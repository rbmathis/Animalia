using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Alopochen;

/// <summary>
/// Abstract class for Alopochen (genus).
/// NCBI TaxId: 30381
/// </summary>
public abstract class Alopochen : Anatidae, IAlopochen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alopochen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30381;

    /// <inheritdoc />
    public virtual string GenusName => "Alopochen";

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
