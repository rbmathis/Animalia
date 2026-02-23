using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius;

/// <summary>
/// Abstract class for Hyperolius (genus).
/// NCBI TaxId: 39588
/// </summary>
public abstract class Hyperolius : Hyperoliidae, IHyperolius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyperolius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39588;

    /// <inheritdoc />
    public virtual string GenusName => "Hyperolius";

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
