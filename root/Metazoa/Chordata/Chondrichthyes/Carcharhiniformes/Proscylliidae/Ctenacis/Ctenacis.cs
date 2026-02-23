using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae.Ctenacis;

/// <summary>
/// Abstract class for Ctenacis (genus).
/// NCBI TaxId: 3236808
/// </summary>
public abstract class Ctenacis : Proscylliidae, ICtenacis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenacis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3236808;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenacis";

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
