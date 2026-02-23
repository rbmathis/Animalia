using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Opisthotropis;

/// <summary>
/// Abstract class for Opisthotropis (genus).
/// NCBI TaxId: 763641
/// </summary>
public abstract class Opisthotropis : Colubridae, IOpisthotropis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opisthotropis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 763641;

    /// <inheritdoc />
    public virtual string GenusName => "Opisthotropis";

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
