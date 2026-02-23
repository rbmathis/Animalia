using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Bario;

/// <summary>
/// Abstract class for Bario (genus).
/// NCBI TaxId: 930298
/// </summary>
public abstract class Bario : Acestrorhamphidae, IBario
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bario";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930298;

    /// <inheritdoc />
    public virtual string GenusName => "Bario";

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
