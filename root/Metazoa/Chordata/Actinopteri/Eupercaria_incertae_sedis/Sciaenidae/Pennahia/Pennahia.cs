using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pennahia;

/// <summary>
/// Abstract class for Pennahia (genus).
/// NCBI TaxId: 118564
/// </summary>
public abstract class Pennahia : Sciaenidae, IPennahia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pennahia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118564;

    /// <inheritdoc />
    public virtual string GenusName => "Pennahia";

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
