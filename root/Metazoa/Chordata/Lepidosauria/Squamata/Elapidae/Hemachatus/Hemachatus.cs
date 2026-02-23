using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Hemachatus;

/// <summary>
/// Abstract class for Hemachatus (genus).
/// NCBI TaxId: 8625
/// </summary>
public abstract class Hemachatus : Elapidae, IHemachatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemachatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8625;

    /// <inheritdoc />
    public virtual string GenusName => "Hemachatus";

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
