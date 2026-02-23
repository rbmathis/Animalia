using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Pristella;

/// <summary>
/// Abstract class for Pristella (genus).
/// NCBI TaxId: 681931
/// </summary>
public abstract class Pristella : Acestrorhamphidae, IPristella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681931;

    /// <inheritdoc />
    public virtual string GenusName => "Pristella";

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
