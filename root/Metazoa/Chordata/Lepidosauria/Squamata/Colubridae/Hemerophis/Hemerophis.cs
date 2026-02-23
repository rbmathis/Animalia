using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Hemerophis;

/// <summary>
/// Abstract class for Hemerophis (genus).
/// NCBI TaxId: 166104
/// </summary>
public abstract class Hemerophis : Colubridae, IHemerophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemerophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166104;

    /// <inheritdoc />
    public virtual string GenusName => "Hemerophis";

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
