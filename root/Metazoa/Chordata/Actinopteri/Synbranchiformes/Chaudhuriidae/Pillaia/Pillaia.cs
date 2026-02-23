using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Chaudhuriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Chaudhuriidae.Pillaia;

/// <summary>
/// Abstract class for Pillaia (genus).
/// NCBI TaxId: 1778382
/// </summary>
public abstract class Pillaia : Chaudhuriidae, IPillaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pillaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1778382;

    /// <inheritdoc />
    public virtual string GenusName => "Pillaia";

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
