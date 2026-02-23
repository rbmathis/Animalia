using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Lobocheilos;

/// <summary>
/// Abstract class for Lobocheilos (genus).
/// NCBI TaxId: 369636
/// </summary>
public abstract class Lobocheilos : Cyprinidae, ILobocheilos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lobocheilos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369636;

    /// <inheritdoc />
    public virtual string GenusName => "Lobocheilos";

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
