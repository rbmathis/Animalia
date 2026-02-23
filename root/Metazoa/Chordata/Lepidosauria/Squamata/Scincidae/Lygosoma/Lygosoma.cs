using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lygosoma;

/// <summary>
/// Abstract class for Lygosoma (genus).
/// NCBI TaxId: 96746
/// </summary>
public abstract class Lygosoma : Scincidae, ILygosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lygosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96746;

    /// <inheritdoc />
    public virtual string GenusName => "Lygosoma";

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
