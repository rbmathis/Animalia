using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Lobotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Lobotidae.Lobotes;

/// <summary>
/// Abstract class for Lobotes (genus).
/// NCBI TaxId: 314246
/// </summary>
public abstract class Lobotes : Lobotidae, ILobotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lobotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 314246;

    /// <inheritdoc />
    public virtual string GenusName => "Lobotes";

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
