using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Chlorosoma;

/// <summary>
/// Abstract class for Chlorosoma (genus).
/// NCBI TaxId: 2816980
/// </summary>
public abstract class Chlorosoma : Dipsadidae, IChlorosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2816980;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorosoma";

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
