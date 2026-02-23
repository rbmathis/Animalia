using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Xenurobrycon;

/// <summary>
/// Abstract class for Xenurobrycon (genus).
/// NCBI TaxId: 930378
/// </summary>
public abstract class Xenurobrycon : Stevardiidae, IXenurobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenurobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930378;

    /// <inheritdoc />
    public virtual string GenusName => "Xenurobrycon";

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
