using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Chondrostoma;

/// <summary>
/// Abstract class for Chondrostoma (genus).
/// NCBI TaxId: 52618
/// </summary>
public abstract class Chondrostoma : Leuciscidae, IChondrostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chondrostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52618;

    /// <inheritdoc />
    public virtual string GenusName => "Chondrostoma";

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
