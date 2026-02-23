using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Amphiesma;

/// <summary>
/// Abstract class for Amphiesma (genus).
/// NCBI TaxId: 183597
/// </summary>
public abstract class Amphiesma : Colubridae, IAmphiesma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amphiesma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183597;

    /// <inheritdoc />
    public virtual string GenusName => "Amphiesma";

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
