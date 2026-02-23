using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae.Xenomystus;

/// <summary>
/// Abstract class for Xenomystus (genus).
/// NCBI TaxId: 112161
/// </summary>
public abstract class Xenomystus : Notopteridae, IXenomystus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenomystus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 112161;

    /// <inheritdoc />
    public virtual string GenusName => "Xenomystus";

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
