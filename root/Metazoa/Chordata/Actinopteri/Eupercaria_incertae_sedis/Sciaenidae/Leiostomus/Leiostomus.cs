using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Leiostomus;

/// <summary>
/// Abstract class for Leiostomus (genus).
/// NCBI TaxId: 59836
/// </summary>
public abstract class Leiostomus : Sciaenidae, ILeiostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59836;

    /// <inheritdoc />
    public virtual string GenusName => "Leiostomus";

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
