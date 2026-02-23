using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Alsophis;

/// <summary>
/// Abstract class for Alsophis (genus).
/// NCBI TaxId: 46302
/// </summary>
public abstract class Alsophis : Dipsadidae, IAlsophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alsophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46302;

    /// <inheritdoc />
    public virtual string GenusName => "Alsophis";

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
