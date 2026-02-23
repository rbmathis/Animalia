using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Rinoctes;

/// <summary>
/// Abstract class for Rinoctes (genus).
/// NCBI TaxId: 492046
/// </summary>
public abstract class Rinoctes : Alepocephalidae, IRinoctes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rinoctes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 492046;

    /// <inheritdoc />
    public virtual string GenusName => "Rinoctes";

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
