using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Micrurus;

/// <summary>
/// Abstract class for Micrurus (genus).
/// NCBI TaxId: 8634
/// </summary>
public abstract class Micrurus : Elapidae, IMicrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8634;

    /// <inheritdoc />
    public virtual string GenusName => "Micrurus";

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
