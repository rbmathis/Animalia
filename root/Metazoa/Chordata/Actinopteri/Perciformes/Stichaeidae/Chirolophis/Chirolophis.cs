using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Chirolophis;

/// <summary>
/// Abstract class for Chirolophis (genus).
/// NCBI TaxId: 320614
/// </summary>
public abstract class Chirolophis : Stichaeidae, IChirolophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chirolophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320614;

    /// <inheritdoc />
    public virtual string GenusName => "Chirolophis";

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
