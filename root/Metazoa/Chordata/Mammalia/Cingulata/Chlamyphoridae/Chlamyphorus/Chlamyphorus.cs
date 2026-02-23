using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Chlamyphorus;

/// <summary>
/// Abstract class for Chlamyphorus (genus).
/// NCBI TaxId: 450266
/// </summary>
public abstract class Chlamyphorus : Chlamyphoridae, IChlamyphorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlamyphorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 450266;

    /// <inheritdoc />
    public virtual string GenusName => "Chlamyphorus";

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
