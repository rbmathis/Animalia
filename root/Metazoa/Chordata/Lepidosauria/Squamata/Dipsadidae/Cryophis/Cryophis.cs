using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Cryophis;

/// <summary>
/// Abstract class for Cryophis (genus).
/// NCBI TaxId: 427710
/// </summary>
public abstract class Cryophis : Dipsadidae, ICryophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 427710;

    /// <inheritdoc />
    public virtual string GenusName => "Cryophis";

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
