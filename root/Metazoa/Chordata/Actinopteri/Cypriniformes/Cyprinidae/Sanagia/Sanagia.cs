using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sanagia;

/// <summary>
/// Abstract class for Sanagia (genus).
/// NCBI TaxId: 1108698
/// </summary>
public abstract class Sanagia : Cyprinidae, ISanagia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sanagia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1108698;

    /// <inheritdoc />
    public virtual string GenusName => "Sanagia";

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
