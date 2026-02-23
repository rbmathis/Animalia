using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Geospiza;

/// <summary>
/// Abstract class for Geospiza (genus).
/// NCBI TaxId: 48881
/// </summary>
public abstract class Geospiza : Thraupidae, IGeospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48881;

    /// <inheritdoc />
    public virtual string GenusName => "Geospiza";

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
