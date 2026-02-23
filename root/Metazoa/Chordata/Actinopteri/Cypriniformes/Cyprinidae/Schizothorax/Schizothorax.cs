using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Schizothorax;

/// <summary>
/// Abstract class for Schizothorax (genus).
/// NCBI TaxId: 75361
/// </summary>
public abstract class Schizothorax : Cyprinidae, ISchizothorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schizothorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75361;

    /// <inheritdoc />
    public virtual string GenusName => "Schizothorax";

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
