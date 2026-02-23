using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Moenkhausia;

/// <summary>
/// Abstract class for Moenkhausia (genus).
/// NCBI TaxId: 272068
/// </summary>
public abstract class Moenkhausia : Acestrorhamphidae, IMoenkhausia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Moenkhausia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272068;

    /// <inheritdoc />
    public virtual string GenusName => "Moenkhausia";

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
