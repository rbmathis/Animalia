using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Uma;

/// <summary>
/// Abstract class for Uma (genus).
/// NCBI TaxId: 43644
/// </summary>
public abstract class Uma : Phrynosomatidae, IUma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43644;

    /// <inheritdoc />
    public virtual string GenusName => "Uma";

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
