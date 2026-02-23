using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Acutotyphlops;

/// <summary>
/// Abstract class for Acutotyphlops (genus).
/// NCBI TaxId: 759944
/// </summary>
public abstract class Acutotyphlops : Typhlopidae, IAcutotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acutotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 759944;

    /// <inheritdoc />
    public virtual string GenusName => "Acutotyphlops";

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
