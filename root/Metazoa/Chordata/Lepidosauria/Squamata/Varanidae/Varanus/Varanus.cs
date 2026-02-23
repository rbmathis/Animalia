using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Abstract class for Varanus (genus).
/// NCBI TaxId: 8556
/// </summary>
public abstract class Varanus : Varanidae, IVaranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Varanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8556;

    /// <inheritdoc />
    public virtual string GenusName => "Varanus";

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
