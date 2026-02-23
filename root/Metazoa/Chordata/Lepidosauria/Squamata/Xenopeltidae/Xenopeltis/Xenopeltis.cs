using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenopeltidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenopeltidae.Xenopeltis;

/// <summary>
/// Abstract class for Xenopeltis (genus).
/// NCBI TaxId: 196252
/// </summary>
public abstract class Xenopeltis : Xenopeltidae, IXenopeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenopeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196252;

    /// <inheritdoc />
    public virtual string GenusName => "Xenopeltis";

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
