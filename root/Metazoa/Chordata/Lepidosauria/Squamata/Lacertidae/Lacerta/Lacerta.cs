using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Lacerta;

/// <summary>
/// Abstract class for Lacerta (genus).
/// NCBI TaxId: 8523
/// </summary>
public abstract class Lacerta : Lacertidae, ILacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8523;

    /// <inheritdoc />
    public virtual string GenusName => "Lacerta";

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
