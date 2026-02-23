using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Leptotyphlops;

/// <summary>
/// Abstract class for Leptotyphlops (genus).
/// NCBI TaxId: 39070
/// </summary>
public abstract class Leptotyphlops : Leptotyphlopidae, ILeptotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39070;

    /// <inheritdoc />
    public virtual string GenusName => "Leptotyphlops";

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
