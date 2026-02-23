using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Ghatophryne;

/// <summary>
/// Abstract class for Ghatophryne (genus).
/// NCBI TaxId: 2499169
/// </summary>
public abstract class Ghatophryne : Bufonidae, IGhatophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ghatophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2499169;

    /// <inheritdoc />
    public virtual string GenusName => "Ghatophryne";

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
