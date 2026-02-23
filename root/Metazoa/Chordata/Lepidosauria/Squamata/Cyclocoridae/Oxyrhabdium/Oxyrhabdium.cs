using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae.Oxyrhabdium;

/// <summary>
/// Abstract class for Oxyrhabdium (genus).
/// NCBI TaxId: 186593
/// </summary>
public abstract class Oxyrhabdium : Cyclocoridae, IOxyrhabdium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyrhabdium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186593;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyrhabdium";

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
