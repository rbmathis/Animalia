using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Lophiobrycon;

/// <summary>
/// Abstract class for Lophiobrycon (genus).
/// NCBI TaxId: 883868
/// </summary>
public abstract class Lophiobrycon : Stevardiidae, ILophiobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophiobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 883868;

    /// <inheritdoc />
    public virtual string GenusName => "Lophiobrycon";

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
