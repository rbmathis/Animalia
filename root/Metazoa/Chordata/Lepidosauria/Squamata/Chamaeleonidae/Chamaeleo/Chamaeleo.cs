using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Chamaeleo;

/// <summary>
/// Abstract class for Chamaeleo (genus).
/// NCBI TaxId: 51754
/// </summary>
public abstract class Chamaeleo : Chamaeleonidae, IChamaeleo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chamaeleo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51754;

    /// <inheritdoc />
    public virtual string GenusName => "Chamaeleo";

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
