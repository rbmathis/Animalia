using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Holopristis;

/// <summary>
/// Abstract class for Holopristis (genus).
/// NCBI TaxId: 3391997
/// </summary>
public abstract class Holopristis : Acestrorhamphidae, IHolopristis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holopristis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3391997;

    /// <inheritdoc />
    public virtual string GenusName => "Holopristis";

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
