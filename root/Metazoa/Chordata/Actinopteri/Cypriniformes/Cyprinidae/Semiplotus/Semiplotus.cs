using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Semiplotus;

/// <summary>
/// Abstract class for Semiplotus (genus).
/// NCBI TaxId: 1504154
/// </summary>
public abstract class Semiplotus : Cyprinidae, ISemiplotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Semiplotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1504154;

    /// <inheritdoc />
    public virtual string GenusName => "Semiplotus";

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
