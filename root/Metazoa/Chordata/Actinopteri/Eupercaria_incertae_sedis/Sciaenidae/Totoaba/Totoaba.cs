using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Totoaba;

/// <summary>
/// Abstract class for Totoaba (genus).
/// NCBI TaxId: 245094
/// </summary>
public abstract class Totoaba : Sciaenidae, ITotoaba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Totoaba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245094;

    /// <inheritdoc />
    public virtual string GenusName => "Totoaba";

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
