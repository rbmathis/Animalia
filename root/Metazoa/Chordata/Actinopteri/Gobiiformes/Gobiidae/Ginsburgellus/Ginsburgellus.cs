using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ginsburgellus;

/// <summary>
/// Abstract class for Ginsburgellus (genus).
/// NCBI TaxId: 203312
/// </summary>
public abstract class Ginsburgellus : Gobiidae, IGinsburgellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ginsburgellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203312;

    /// <inheritdoc />
    public virtual string GenusName => "Ginsburgellus";

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
