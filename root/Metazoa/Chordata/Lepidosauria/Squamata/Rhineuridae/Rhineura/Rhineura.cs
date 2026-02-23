using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Rhineuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Rhineuridae.Rhineura;

/// <summary>
/// Abstract class for Rhineura (genus).
/// NCBI TaxId: 261502
/// </summary>
public abstract class Rhineura : Rhineuridae, IRhineura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhineura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261502;

    /// <inheritdoc />
    public virtual string GenusName => "Rhineura";

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
