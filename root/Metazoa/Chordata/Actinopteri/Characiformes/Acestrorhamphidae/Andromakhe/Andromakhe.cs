using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Andromakhe;

/// <summary>
/// Abstract class for Andromakhe (genus).
/// NCBI TaxId: 2729153
/// </summary>
public abstract class Andromakhe : Acestrorhamphidae, IAndromakhe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Andromakhe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2729153;

    /// <inheritdoc />
    public virtual string GenusName => "Andromakhe";

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
