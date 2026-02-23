using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Plectrypops;

/// <summary>
/// Abstract class for Plectrypops (genus).
/// NCBI TaxId: 753650
/// </summary>
public abstract class Plectrypops : Holocentridae, IPlectrypops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectrypops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 753650;

    /// <inheritdoc />
    public virtual string GenusName => "Plectrypops";

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
