using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eulamprus;

/// <summary>
/// Abstract class for Eulamprus (genus).
/// NCBI TaxId: 136853
/// </summary>
public abstract class Eulamprus : Scincidae, IEulamprus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eulamprus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 136853;

    /// <inheritdoc />
    public virtual string GenusName => "Eulamprus";

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
