using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Trioceros;

/// <summary>
/// Abstract class for Trioceros (genus).
/// NCBI TaxId: 649456
/// </summary>
public abstract class Trioceros : Chamaeleonidae, ITrioceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trioceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 649456;

    /// <inheritdoc />
    public virtual string GenusName => "Trioceros";

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
