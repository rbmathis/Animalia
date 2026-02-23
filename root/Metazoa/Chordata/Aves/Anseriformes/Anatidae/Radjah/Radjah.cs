using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Radjah;

/// <summary>
/// Abstract class for Radjah (genus).
/// NCBI TaxId: 3150769
/// </summary>
public abstract class Radjah : Anatidae, IRadjah
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Radjah";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150769;

    /// <inheritdoc />
    public virtual string GenusName => "Radjah";

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
