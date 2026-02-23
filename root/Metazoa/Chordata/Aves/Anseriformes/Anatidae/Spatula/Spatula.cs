using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Spatula;

/// <summary>
/// Abstract class for Spatula (genus).
/// NCBI TaxId: 2823197
/// </summary>
public abstract class Spatula : Anatidae, ISpatula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spatula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823197;

    /// <inheritdoc />
    public virtual string GenusName => "Spatula";

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
