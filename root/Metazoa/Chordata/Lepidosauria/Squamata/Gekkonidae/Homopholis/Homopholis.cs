using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Homopholis;

/// <summary>
/// Abstract class for Homopholis (genus).
/// NCBI TaxId: 401536
/// </summary>
public abstract class Homopholis : Gekkonidae, IHomopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 401536;

    /// <inheritdoc />
    public virtual string GenusName => "Homopholis";

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
