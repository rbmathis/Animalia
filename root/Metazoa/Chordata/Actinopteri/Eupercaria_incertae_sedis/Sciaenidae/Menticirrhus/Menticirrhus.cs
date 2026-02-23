using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Menticirrhus;

/// <summary>
/// Abstract class for Menticirrhus (genus).
/// NCBI TaxId: 278733
/// </summary>
public abstract class Menticirrhus : Sciaenidae, IMenticirrhus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Menticirrhus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 278733;

    /// <inheritdoc />
    public virtual string GenusName => "Menticirrhus";

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
