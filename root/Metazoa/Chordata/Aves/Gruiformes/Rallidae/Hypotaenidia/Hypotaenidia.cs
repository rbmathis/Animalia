using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Hypotaenidia;

/// <summary>
/// Abstract class for Hypotaenidia (genus).
/// NCBI TaxId: 2861790
/// </summary>
public abstract class Hypotaenidia : Rallidae, IHypotaenidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypotaenidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861790;

    /// <inheritdoc />
    public virtual string GenusName => "Hypotaenidia";

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
