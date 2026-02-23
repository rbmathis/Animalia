using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Aldrichetta;

/// <summary>
/// Abstract class for Aldrichetta (genus).
/// NCBI TaxId: 443747
/// </summary>
public abstract class Aldrichetta : Mugilidae, IAldrichetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aldrichetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443747;

    /// <inheritdoc />
    public virtual string GenusName => "Aldrichetta";

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
