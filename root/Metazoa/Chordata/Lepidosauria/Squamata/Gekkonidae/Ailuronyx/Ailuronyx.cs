using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Ailuronyx;

/// <summary>
/// Abstract class for Ailuronyx (genus).
/// NCBI TaxId: 232284
/// </summary>
public abstract class Ailuronyx : Gekkonidae, IAiluronyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ailuronyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 232284;

    /// <inheritdoc />
    public virtual string GenusName => "Ailuronyx";

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
