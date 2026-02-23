using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Boehmantis;

/// <summary>
/// Abstract class for Boehmantis (genus).
/// NCBI TaxId: 403235
/// </summary>
public abstract class Boehmantis : Mantellidae, IBoehmantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boehmantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 403235;

    /// <inheritdoc />
    public virtual string GenusName => "Boehmantis";

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
