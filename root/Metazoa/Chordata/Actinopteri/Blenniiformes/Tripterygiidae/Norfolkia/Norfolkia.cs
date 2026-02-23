using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Norfolkia;

/// <summary>
/// Abstract class for Norfolkia (genus).
/// NCBI TaxId: 1647199
/// </summary>
public abstract class Norfolkia : Tripterygiidae, INorfolkia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Norfolkia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1647199;

    /// <inheritdoc />
    public virtual string GenusName => "Norfolkia";

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
