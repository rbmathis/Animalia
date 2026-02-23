using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Boaedon;

/// <summary>
/// Abstract class for Boaedon (genus).
/// NCBI TaxId: 1419107
/// </summary>
public abstract class Boaedon : Lamprophiidae, IBoaedon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boaedon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1419107;

    /// <inheritdoc />
    public virtual string GenusName => "Boaedon";

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
