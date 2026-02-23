using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Myripristis;

/// <summary>
/// Abstract class for Myripristis (genus).
/// NCBI TaxId: 47699
/// </summary>
public abstract class Myripristis : Holocentridae, IMyripristis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myripristis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47699;

    /// <inheritdoc />
    public virtual string GenusName => "Myripristis";

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
