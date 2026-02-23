using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Lycognathophis;

/// <summary>
/// Abstract class for Lycognathophis (genus).
/// NCBI TaxId: 578148
/// </summary>
public abstract class Lycognathophis : Colubridae, ILycognathophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycognathophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 578148;

    /// <inheritdoc />
    public virtual string GenusName => "Lycognathophis";

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
