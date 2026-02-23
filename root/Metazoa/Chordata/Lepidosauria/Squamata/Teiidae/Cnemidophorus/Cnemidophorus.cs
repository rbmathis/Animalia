using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Cnemidophorus;

/// <summary>
/// Abstract class for Cnemidophorus (genus).
/// NCBI TaxId: 37196
/// </summary>
public abstract class Cnemidophorus : Teiidae, ICnemidophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cnemidophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37196;

    /// <inheritdoc />
    public virtual string GenusName => "Cnemidophorus";

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
