using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sawbwa;

/// <summary>
/// Abstract class for Sawbwa (genus).
/// NCBI TaxId: 198505
/// </summary>
public abstract class Sawbwa : Cyprinidae, ISawbwa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sawbwa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 198505;

    /// <inheritdoc />
    public virtual string GenusName => "Sawbwa";

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
