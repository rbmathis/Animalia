using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scincopus;

/// <summary>
/// Abstract class for Scincopus (genus).
/// NCBI TaxId: 246186
/// </summary>
public abstract class Scincopus : Scincidae, IScincopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scincopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 246186;

    /// <inheritdoc />
    public virtual string GenusName => "Scincopus";

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
