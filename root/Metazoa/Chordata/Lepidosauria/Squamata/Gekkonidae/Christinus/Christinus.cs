using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Christinus;

/// <summary>
/// Abstract class for Christinus (genus).
/// NCBI TaxId: 221555
/// </summary>
public abstract class Christinus : Gekkonidae, IChristinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Christinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221555;

    /// <inheritdoc />
    public virtual string GenusName => "Christinus";

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
