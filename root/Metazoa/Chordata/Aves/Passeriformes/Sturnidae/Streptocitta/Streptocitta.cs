using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Streptocitta;

/// <summary>
/// Abstract class for Streptocitta (genus).
/// NCBI TaxId: 451436
/// </summary>
public abstract class Streptocitta : Sturnidae, IStreptocitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Streptocitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 451436;

    /// <inheritdoc />
    public virtual string GenusName => "Streptocitta";

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
