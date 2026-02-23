using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Algyroides;

/// <summary>
/// Abstract class for Algyroides (genus).
/// NCBI TaxId: 64411
/// </summary>
public abstract class Algyroides : Lacertidae, IAlgyroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Algyroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64411;

    /// <inheritdoc />
    public virtual string GenusName => "Algyroides";

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
