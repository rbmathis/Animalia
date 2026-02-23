using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Diaphorolepis;

/// <summary>
/// Abstract class for Diaphorolepis (genus).
/// NCBI TaxId: 1544560
/// </summary>
public abstract class Diaphorolepis : Dipsadidae, IDiaphorolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diaphorolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544560;

    /// <inheritdoc />
    public virtual string GenusName => "Diaphorolepis";

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
