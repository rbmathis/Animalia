using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Herzensteinia;

/// <summary>
/// Abstract class for Herzensteinia (genus).
/// NCBI TaxId: 361641
/// </summary>
public abstract class Herzensteinia : Cyprinidae, IHerzensteinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Herzensteinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 361641;

    /// <inheritdoc />
    public virtual string GenusName => "Herzensteinia";

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
