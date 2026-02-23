using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Linichthys;

/// <summary>
/// Abstract class for Linichthys (genus).
/// NCBI TaxId: 497006
/// </summary>
public abstract class Linichthys : Cyprinidae, ILinichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Linichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 497006;

    /// <inheritdoc />
    public virtual string GenusName => "Linichthys";

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
