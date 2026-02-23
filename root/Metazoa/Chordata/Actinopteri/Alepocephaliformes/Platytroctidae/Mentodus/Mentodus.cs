using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Mentodus;

/// <summary>
/// Abstract class for Mentodus (genus).
/// NCBI TaxId: 2100597
/// </summary>
public abstract class Mentodus : Platytroctidae, IMentodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mentodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2100597;

    /// <inheritdoc />
    public virtual string GenusName => "Mentodus";

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
