using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Xyelodontophis;

/// <summary>
/// Abstract class for Xyelodontophis (genus).
/// NCBI TaxId: 1328034
/// </summary>
public abstract class Xyelodontophis : Colubridae, IXyelodontophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xyelodontophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1328034;

    /// <inheritdoc />
    public virtual string GenusName => "Xyelodontophis";

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
