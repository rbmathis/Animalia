using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Hypobrycon;

/// <summary>
/// Abstract class for Hypobrycon (genus).
/// NCBI TaxId: 681947
/// </summary>
public abstract class Hypobrycon : Stevardiidae, IHypobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681947;

    /// <inheritdoc />
    public virtual string GenusName => "Hypobrycon";

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
