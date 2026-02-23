using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Biziura;

/// <summary>
/// Abstract class for Biziura (genus).
/// NCBI TaxId: 45647
/// </summary>
public abstract class Biziura : Anatidae, IBiziura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Biziura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45647;

    /// <inheritdoc />
    public virtual string GenusName => "Biziura";

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
