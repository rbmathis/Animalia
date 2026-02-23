using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Pholidoscelis;

/// <summary>
/// Abstract class for Pholidoscelis (genus).
/// NCBI TaxId: 2026238
/// </summary>
public abstract class Pholidoscelis : Teiidae, IPholidoscelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pholidoscelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2026238;

    /// <inheritdoc />
    public virtual string GenusName => "Pholidoscelis";

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
