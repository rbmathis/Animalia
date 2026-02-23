using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Antillotyphlops;

/// <summary>
/// Abstract class for Antillotyphlops (genus).
/// NCBI TaxId: 1492666
/// </summary>
public abstract class Antillotyphlops : Typhlopidae, IAntillotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antillotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1492666;

    /// <inheritdoc />
    public virtual string GenusName => "Antillotyphlops";

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
