using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Thymallus;

/// <summary>
/// Abstract class for Thymallus (genus).
/// NCBI TaxId: 36184
/// </summary>
public abstract class Thymallus : Salmonidae, IThymallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thymallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36184;

    /// <inheritdoc />
    public virtual string GenusName => "Thymallus";

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
