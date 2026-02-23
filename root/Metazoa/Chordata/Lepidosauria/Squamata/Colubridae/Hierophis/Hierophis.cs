using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Hierophis;

/// <summary>
/// Abstract class for Hierophis (genus).
/// NCBI TaxId: 166079
/// </summary>
public abstract class Hierophis : Colubridae, IHierophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hierophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166079;

    /// <inheritdoc />
    public virtual string GenusName => "Hierophis";

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
