using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Pseudocorynopoma;

/// <summary>
/// Abstract class for Pseudocorynopoma (genus).
/// NCBI TaxId: 681933
/// </summary>
public abstract class Pseudocorynopoma : Stevardiidae, IPseudocorynopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocorynopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681933;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocorynopoma";

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
