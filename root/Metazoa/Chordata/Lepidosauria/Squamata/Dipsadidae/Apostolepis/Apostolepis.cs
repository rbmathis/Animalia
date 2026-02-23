using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Apostolepis;

/// <summary>
/// Abstract class for Apostolepis (genus).
/// NCBI TaxId: 666067
/// </summary>
public abstract class Apostolepis : Dipsadidae, IApostolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apostolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666067;

    /// <inheritdoc />
    public virtual string GenusName => "Apostolepis";

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
