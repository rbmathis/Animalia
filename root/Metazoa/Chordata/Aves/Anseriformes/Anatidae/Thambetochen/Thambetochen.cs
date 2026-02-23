using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Thambetochen;

/// <summary>
/// Abstract class for Thambetochen (genus).
/// NCBI TaxId: 107029
/// </summary>
public abstract class Thambetochen : Anatidae, IThambetochen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thambetochen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107029;

    /// <inheritdoc />
    public virtual string GenusName => "Thambetochen";

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
