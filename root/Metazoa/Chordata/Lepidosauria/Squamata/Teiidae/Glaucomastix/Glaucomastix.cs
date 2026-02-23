using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Glaucomastix;

/// <summary>
/// Abstract class for Glaucomastix (genus).
/// NCBI TaxId: 2026254
/// </summary>
public abstract class Glaucomastix : Teiidae, IGlaucomastix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaucomastix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2026254;

    /// <inheritdoc />
    public virtual string GenusName => "Glaucomastix";

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
