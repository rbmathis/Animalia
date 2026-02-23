using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Colocongridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Colocongridae.Coloconger;

/// <summary>
/// Abstract class for Coloconger (genus).
/// NCBI TaxId: 391218
/// </summary>
public abstract class Coloconger : Colocongridae, IColoconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coloconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391218;

    /// <inheritdoc />
    public virtual string GenusName => "Coloconger";

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
