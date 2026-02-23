using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Typhlops;

/// <summary>
/// Abstract class for Typhlops (genus).
/// NCBI TaxId: 39093
/// </summary>
public abstract class Typhlops : Typhlopidae, ITyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39093;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlops";

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
