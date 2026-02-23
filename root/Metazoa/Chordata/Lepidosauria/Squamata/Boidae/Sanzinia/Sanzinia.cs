using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Sanzinia;

/// <summary>
/// Abstract class for Sanzinia (genus).
/// NCBI TaxId: 51880
/// </summary>
public abstract class Sanzinia : Boidae, ISanzinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sanzinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51880;

    /// <inheritdoc />
    public virtual string GenusName => "Sanzinia";

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
