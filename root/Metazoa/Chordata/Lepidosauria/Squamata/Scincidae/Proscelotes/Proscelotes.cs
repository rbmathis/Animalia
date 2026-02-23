using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Proscelotes;

/// <summary>
/// Abstract class for Proscelotes (genus).
/// NCBI TaxId: 211868
/// </summary>
public abstract class Proscelotes : Scincidae, IProscelotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proscelotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 211868;

    /// <inheritdoc />
    public virtual string GenusName => "Proscelotes";

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
