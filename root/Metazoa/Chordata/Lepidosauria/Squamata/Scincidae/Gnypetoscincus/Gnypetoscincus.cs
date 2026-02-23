using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Gnypetoscincus;

/// <summary>
/// Abstract class for Gnypetoscincus (genus).
/// NCBI TaxId: 27795
/// </summary>
public abstract class Gnypetoscincus : Scincidae, IGnypetoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnypetoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27795;

    /// <inheritdoc />
    public virtual string GenusName => "Gnypetoscincus";

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
