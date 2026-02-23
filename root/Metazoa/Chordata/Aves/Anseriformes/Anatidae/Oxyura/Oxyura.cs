using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Oxyura;

/// <summary>
/// Abstract class for Oxyura (genus).
/// NCBI TaxId: 8883
/// </summary>
public abstract class Oxyura : Anatidae, IOxyura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8883;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyura";

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
