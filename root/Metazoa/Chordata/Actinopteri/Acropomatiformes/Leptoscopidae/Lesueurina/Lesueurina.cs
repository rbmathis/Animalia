using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Leptoscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Leptoscopidae.Lesueurina;

/// <summary>
/// Abstract class for Lesueurina (genus).
/// NCBI TaxId: 390345
/// </summary>
public abstract class Lesueurina : Leptoscopidae, ILesueurina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lesueurina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390345;

    /// <inheritdoc />
    public virtual string GenusName => "Lesueurina";

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
