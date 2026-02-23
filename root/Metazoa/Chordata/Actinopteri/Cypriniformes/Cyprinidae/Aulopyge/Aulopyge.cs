using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Aulopyge;

/// <summary>
/// Abstract class for Aulopyge (genus).
/// NCBI TaxId: 117141
/// </summary>
public abstract class Aulopyge : Cyprinidae, IAulopyge
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aulopyge";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117141;

    /// <inheritdoc />
    public virtual string GenusName => "Aulopyge";

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
