using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Chelmonops;

/// <summary>
/// Abstract class for Chelmonops (genus).
/// NCBI TaxId: 466145
/// </summary>
public abstract class Chelmonops : Chaetodontidae, IChelmonops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelmonops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 466145;

    /// <inheritdoc />
    public virtual string GenusName => "Chelmonops";

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
