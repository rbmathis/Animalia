using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Acrobrycon;

/// <summary>
/// Abstract class for Acrobrycon (genus).
/// NCBI TaxId: 1463110
/// </summary>
public abstract class Acrobrycon : Stevardiidae, IAcrobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acrobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463110;

    /// <inheritdoc />
    public virtual string GenusName => "Acrobrycon";

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
