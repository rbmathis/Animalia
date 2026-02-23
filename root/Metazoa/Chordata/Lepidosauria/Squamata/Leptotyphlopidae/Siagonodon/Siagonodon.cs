using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Siagonodon;

/// <summary>
/// Abstract class for Siagonodon (genus).
/// NCBI TaxId: 711336
/// </summary>
public abstract class Siagonodon : Leptotyphlopidae, ISiagonodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siagonodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 711336;

    /// <inheritdoc />
    public virtual string GenusName => "Siagonodon";

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
