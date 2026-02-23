using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Aspidites;

/// <summary>
/// Abstract class for Aspidites (genus).
/// NCBI TaxId: 51882
/// </summary>
public abstract class Aspidites : Pythonidae, IAspidites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspidites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51882;

    /// <inheritdoc />
    public virtual string GenusName => "Aspidites";

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
