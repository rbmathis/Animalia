using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Mesaspis;

/// <summary>
/// Abstract class for Mesaspis (genus).
/// NCBI TaxId: 76655
/// </summary>
public abstract class Mesaspis : Anguidae, IMesaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76655;

    /// <inheritdoc />
    public virtual string GenusName => "Mesaspis";

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
