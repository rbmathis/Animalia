using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Pomatorhinus;

/// <summary>
/// Abstract class for Pomatorhinus (genus).
/// NCBI TaxId: 98147
/// </summary>
public abstract class Pomatorhinus : Timaliidae, IPomatorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pomatorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98147;

    /// <inheritdoc />
    public virtual string GenusName => "Pomatorhinus";

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
