using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Acrochordidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Acrochordidae.Plagiopholis;

/// <summary>
/// Abstract class for Plagiopholis (genus).
/// NCBI TaxId: 527805
/// </summary>
public abstract class Plagiopholis : Acrochordidae, IPlagiopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plagiopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 527805;

    /// <inheritdoc />
    public virtual string GenusName => "Plagiopholis";

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
