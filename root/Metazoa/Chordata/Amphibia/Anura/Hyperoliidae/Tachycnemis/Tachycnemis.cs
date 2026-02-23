using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Tachycnemis;

/// <summary>
/// Abstract class for Tachycnemis (genus).
/// NCBI TaxId: 39605
/// </summary>
public abstract class Tachycnemis : Hyperoliidae, ITachycnemis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachycnemis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39605;

    /// <inheritdoc />
    public virtual string GenusName => "Tachycnemis";

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
