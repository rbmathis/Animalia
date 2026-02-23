using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Sceloporus;

/// <summary>
/// Abstract class for Sceloporus (genus).
/// NCBI TaxId: 8518
/// </summary>
public abstract class Sceloporus : Phrynosomatidae, ISceloporus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sceloporus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8518;

    /// <inheritdoc />
    public virtual string GenusName => "Sceloporus";

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
