using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Somateria;

/// <summary>
/// Abstract class for Somateria (genus).
/// NCBI TaxId: 50366
/// </summary>
public abstract class Somateria : Anatidae, ISomateria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Somateria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50366;

    /// <inheritdoc />
    public virtual string GenusName => "Somateria";

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
