using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Rhoptropella;

/// <summary>
/// Abstract class for Rhoptropella (genus).
/// NCBI TaxId: 798149
/// </summary>
public abstract class Rhoptropella : Gekkonidae, IRhoptropella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhoptropella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 798149;

    /// <inheritdoc />
    public virtual string GenusName => "Rhoptropella";

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
