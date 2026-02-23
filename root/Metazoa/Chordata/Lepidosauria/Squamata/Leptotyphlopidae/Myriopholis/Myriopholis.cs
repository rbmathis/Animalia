using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Myriopholis;

/// <summary>
/// Abstract class for Myriopholis (genus).
/// NCBI TaxId: 711079
/// </summary>
public abstract class Myriopholis : Leptotyphlopidae, IMyriopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myriopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 711079;

    /// <inheritdoc />
    public virtual string GenusName => "Myriopholis";

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
