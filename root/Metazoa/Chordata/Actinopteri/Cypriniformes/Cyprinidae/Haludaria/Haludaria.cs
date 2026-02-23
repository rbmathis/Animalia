using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Haludaria;

/// <summary>
/// Abstract class for Haludaria (genus).
/// NCBI TaxId: 1503184
/// </summary>
public abstract class Haludaria : Cyprinidae, IHaludaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haludaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1503184;

    /// <inheritdoc />
    public virtual string GenusName => "Haludaria";

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
