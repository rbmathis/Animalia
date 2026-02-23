using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Charina;

/// <summary>
/// Abstract class for Charina (genus).
/// NCBI TaxId: 39156
/// </summary>
public abstract class Charina : Boidae, ICharina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Charina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39156;

    /// <inheritdoc />
    public virtual string GenusName => "Charina";

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
