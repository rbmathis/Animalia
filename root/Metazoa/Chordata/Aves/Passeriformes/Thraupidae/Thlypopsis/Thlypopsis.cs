using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Thlypopsis;

/// <summary>
/// Abstract class for Thlypopsis (genus).
/// NCBI TaxId: 62256
/// </summary>
public abstract class Thlypopsis : Thraupidae, IThlypopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thlypopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62256;

    /// <inheritdoc />
    public virtual string GenusName => "Thlypopsis";

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
