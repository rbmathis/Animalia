using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Leiolepis;

/// <summary>
/// Abstract class for Leiolepis (genus).
/// NCBI TaxId: 52195
/// </summary>
public abstract class Leiolepis : Agamidae, ILeiolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52195;

    /// <inheritdoc />
    public virtual string GenusName => "Leiolepis";

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
