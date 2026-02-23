using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Liopholis;

/// <summary>
/// Abstract class for Liopholis (genus).
/// NCBI TaxId: 1041596
/// </summary>
public abstract class Liopholis : Scincidae, ILiopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1041596;

    /// <inheritdoc />
    public virtual string GenusName => "Liopholis";

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
