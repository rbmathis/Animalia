using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Puntioplites;

/// <summary>
/// Abstract class for Puntioplites (genus).
/// NCBI TaxId: 227278
/// </summary>
public abstract class Puntioplites : Cyprinidae, IPuntioplites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Puntioplites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227278;

    /// <inheritdoc />
    public virtual string GenusName => "Puntioplites";

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
