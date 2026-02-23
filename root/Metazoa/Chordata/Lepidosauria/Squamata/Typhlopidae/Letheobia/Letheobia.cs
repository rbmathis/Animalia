using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Letheobia;

/// <summary>
/// Abstract class for Letheobia (genus).
/// NCBI TaxId: 759998
/// </summary>
public abstract class Letheobia : Typhlopidae, ILetheobia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Letheobia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 759998;

    /// <inheritdoc />
    public virtual string GenusName => "Letheobia";

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
