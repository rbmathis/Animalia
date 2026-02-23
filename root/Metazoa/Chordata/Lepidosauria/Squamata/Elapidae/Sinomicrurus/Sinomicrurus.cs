using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Sinomicrurus;

/// <summary>
/// Abstract class for Sinomicrurus (genus).
/// NCBI TaxId: 184155
/// </summary>
public abstract class Sinomicrurus : Elapidae, ISinomicrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinomicrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184155;

    /// <inheritdoc />
    public virtual string GenusName => "Sinomicrurus";

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
