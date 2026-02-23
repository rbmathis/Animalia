using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Altigena;

/// <summary>
/// Abstract class for Altigena (genus).
/// NCBI TaxId: 2517876
/// </summary>
public abstract class Altigena : Cyprinidae, IAltigena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Altigena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2517876;

    /// <inheritdoc />
    public virtual string GenusName => "Altigena";

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
