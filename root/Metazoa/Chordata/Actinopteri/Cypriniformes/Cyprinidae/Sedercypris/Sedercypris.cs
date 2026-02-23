using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sedercypris;

/// <summary>
/// Abstract class for Sedercypris (genus).
/// NCBI TaxId: 2890846
/// </summary>
public abstract class Sedercypris : Cyprinidae, ISedercypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sedercypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2890846;

    /// <inheritdoc />
    public virtual string GenusName => "Sedercypris";

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
