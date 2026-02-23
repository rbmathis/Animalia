using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Micropogonias;

/// <summary>
/// Abstract class for Micropogonias (genus).
/// NCBI TaxId: 29153
/// </summary>
public abstract class Micropogonias : Sciaenidae, IMicropogonias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micropogonias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29153;

    /// <inheritdoc />
    public virtual string GenusName => "Micropogonias";

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
