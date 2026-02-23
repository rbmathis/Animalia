using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Melanospiza;

/// <summary>
/// Abstract class for Melanospiza (genus).
/// NCBI TaxId: 138932
/// </summary>
public abstract class Melanospiza : Thraupidae, IMelanospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 138932;

    /// <inheritdoc />
    public virtual string GenusName => "Melanospiza";

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
