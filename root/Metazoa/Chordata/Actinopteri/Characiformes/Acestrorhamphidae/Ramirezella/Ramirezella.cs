using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Ramirezella;

/// <summary>
/// Abstract class for Ramirezella (genus).
/// NCBI TaxId: 3391998
/// </summary>
public abstract class Ramirezella : Acestrorhamphidae, IRamirezella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramirezella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3391998;

    /// <inheritdoc />
    public virtual string GenusName => "Ramirezella";

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
