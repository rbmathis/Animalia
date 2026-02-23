using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Pethia;

/// <summary>
/// Abstract class for Pethia (genus).
/// NCBI TaxId: 1278288
/// </summary>
public abstract class Pethia : Cyprinidae, IPethia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pethia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1278288;

    /// <inheritdoc />
    public virtual string GenusName => "Pethia";

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
