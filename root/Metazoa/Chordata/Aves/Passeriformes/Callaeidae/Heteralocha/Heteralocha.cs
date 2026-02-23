using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Callaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Callaeidae.Heteralocha;

/// <summary>
/// Abstract class for Heteralocha (genus).
/// NCBI TaxId: 192210
/// </summary>
public abstract class Heteralocha : Callaeidae, IHeteralocha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteralocha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192210;

    /// <inheritdoc />
    public virtual string GenusName => "Heteralocha";

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
