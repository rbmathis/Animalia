using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Catlocarpio;

/// <summary>
/// Abstract class for Catlocarpio (genus).
/// NCBI TaxId: 643418
/// </summary>
public abstract class Catlocarpio : Cyprinidae, ICatlocarpio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catlocarpio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643418;

    /// <inheritdoc />
    public virtual string GenusName => "Catlocarpio";

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
