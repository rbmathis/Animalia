using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Leipoa;

/// <summary>
/// Abstract class for Leipoa (genus).
/// NCBI TaxId: 8980
/// </summary>
public abstract class Leipoa : Megapodiidae, ILeipoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leipoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8980;

    /// <inheritdoc />
    public virtual string GenusName => "Leipoa";

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
