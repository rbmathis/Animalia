using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Scelarcis;

/// <summary>
/// Abstract class for Scelarcis (genus).
/// NCBI TaxId: 651322
/// </summary>
public abstract class Scelarcis : Lacertidae, IScelarcis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scelarcis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651322;

    /// <inheritdoc />
    public virtual string GenusName => "Scelarcis";

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
