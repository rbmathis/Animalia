using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Rhadinaea;

/// <summary>
/// Abstract class for Rhadinaea (genus).
/// NCBI TaxId: 427735
/// </summary>
public abstract class Rhadinaea : Dipsadidae, IRhadinaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhadinaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 427735;

    /// <inheritdoc />
    public virtual string GenusName => "Rhadinaea";

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
