using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Euprepiophis;

/// <summary>
/// Abstract class for Euprepiophis (genus).
/// NCBI TaxId: 201799
/// </summary>
public abstract class Euprepiophis : Colubridae, IEuprepiophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euprepiophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201799;

    /// <inheritdoc />
    public virtual string GenusName => "Euprepiophis";

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
