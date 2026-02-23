using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Puntigrus;

/// <summary>
/// Abstract class for Puntigrus (genus).
/// NCBI TaxId: 1606679
/// </summary>
public abstract class Puntigrus : Cyprinidae, IPuntigrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Puntigrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1606679;

    /// <inheritdoc />
    public virtual string GenusName => "Puntigrus";

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
