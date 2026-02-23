using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Epalzeorhynchos;

/// <summary>
/// Abstract class for Epalzeorhynchos (genus).
/// NCBI TaxId: 98647
/// </summary>
public abstract class Epalzeorhynchos : Cyprinidae, IEpalzeorhynchos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epalzeorhynchos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98647;

    /// <inheritdoc />
    public virtual string GenusName => "Epalzeorhynchos";

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
