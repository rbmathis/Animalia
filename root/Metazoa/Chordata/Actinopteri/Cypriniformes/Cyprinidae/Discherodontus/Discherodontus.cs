using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Discherodontus;

/// <summary>
/// Abstract class for Discherodontus (genus).
/// NCBI TaxId: 643440
/// </summary>
public abstract class Discherodontus : Cyprinidae, IDischerodontus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Discherodontus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643440;

    /// <inheritdoc />
    public virtual string GenusName => "Discherodontus";

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
